using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using Newtonsoft.Json;
using UDP;


public class UDPManager : MonoBehaviour
{
    private byte[] bytes;
    static UdpClient udpClient;
    Thread threadReceiver;
    public int port = 9090;
    public string msg_string;
    public int msg_counter;
    public bool update;

    public UDPManagermsg msg_json = new UDPManagermsg();


    void Start()
    {
        msg_counter = 0;
        update = true;
        udpClient = new UdpClient(port);
        threadReceiver = new Thread(new ThreadStart(ThreadReceiver));
        threadReceiver.IsBackground = true;
        threadReceiver.Start();
    }

    void Update()
    {
    }

    void OnApplicationQuit()
    {
        udpClient.Close();
        threadReceiver.Abort();
    }

    private void ThreadReceiver()
    {
        while (update)
        {

            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, port);
            byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);

            msg_string = Encoding.UTF8.GetString(receiveBytes);
            msg_json = JsonConvert.DeserializeObject<UDPManagermsg>(@msg_string);
            
            _update_udp();
            msg_counter = msg_json.data.Count;
        }
    }

    public void _update_udp()
    {
        
        if (msg_counter == msg_json.data.Count)
        {
            update = false;
        }
        else if(msg_counter <= msg_json.data.Count)
        {
            update =  true;
        }
        else
        {
            update = false;
        }


    }
}