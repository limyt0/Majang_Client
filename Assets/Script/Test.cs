using Google.Protobuf;
using Peas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using UnityEngine;

public class Test : MonoBehaviour
{
    private TcpClient client;
    private NetworkStream stream;
    private byte[] buffer = new byte[4096]; // 수신 버퍼
    async Task Start()
    {
        try
        {
            client = new TcpClient();
            // C++ 서버가 WSL에 있다면 "127.0.0.1" 대신 WSL IP를 써야 할 수도 있습니다.
            var connectTask = client.ConnectAsync("127.0.0.1", 2345);

            await connectTask;

            if (client.Connected)
            {
                // 스트림 연결!
                stream = client.GetStream();
                Debug.Log("<color=green>서버 연결 성공!</color>");
            }
        }
        catch (Exception e)
        {
            Debug.LogError($"서버 연결 실패: {e.Message}");
        }
    }
    private void Update()
    {
        ReceiveData();
    }

    void ReceiveData()
    {
        if (stream == null || client.Available < 4) return;

        try
        {
            // 1. 헤더(4바이트) 읽기
            byte[] header = new byte[4];
            stream.Read(header, 0, 4);

            if (BitConverter.IsLittleEndian) Array.Reverse(header);
            int packetSize = BitConverter.ToInt32(header, 0);

            // 2. 실제 데이터 읽기
            byte[] dataBuffer = new byte[packetSize];
            int totalRead = 0;
            while (totalRead < packetSize)
            {
                int read = stream.Read(dataBuffer, totalRead, packetSize - totalRead);
                if (read == 0) break;
                totalRead += read;
            }

            // 3. GamePacket으로 역직렬화 (BeaPea가 아님!)
            GamePacket packet = GamePacket.Parser.ParseFrom(dataBuffer);

            // 4. 내부의 BeaPea 데이터 접근
            if (packet.PayloadCase == GamePacket.PayloadOneofCase.BeaPea)
            {
                ProcessData(packet.BeaPea);
            }
        }
        catch (Exception e)
        {
            Debug.LogError($"수신 에러: {e.Message}");
        }
    }

    void ProcessData(BeaPea data)
    {
        Debug.Log("[수신 성공] RoomID: "+data.Roomid+", JaksaIndex: "+data.Jaksaindex+", "+"sonpaesize: "+data.Sonpeas.Count );
        // repeated 필드는 리스트처럼 반복문 사용 가능
        foreach (int son in data.Sonpeas)
        {
            Debug.Log($"SonPea ID: {son}");
        }
    }


}
