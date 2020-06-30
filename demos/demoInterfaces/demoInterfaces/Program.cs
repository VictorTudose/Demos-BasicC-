using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoInterfaces
{

    // interfete
    // polimorphism

    public interface ISender
    {
        void send(IReceiver r);
    }

    public interface IReceiver
    {
        void recv(ISender s);
    }

    class Node
    {
        protected string name;
        protected Node(string name="node")
        {
            this.name = name;
        }
    }

    class PeerToPeer :Node,ISender , IReceiver
    {

        public void recv(ISender s)
        {
            Console.WriteLine("Pirate "+name+" is receiving");
        }

        public void send(IReceiver r)
        {
            Console.WriteLine("Pirate " + name + " is sending");
        }

        public PeerToPeer(string name) : base(name) {}
    }

    class Server : Node,ISender
    {
        public void send(IReceiver r)
        {
            Console.WriteLine(name + " is sending");
        }
        public Server(string name) : base(name) {}
    }

    class Client : Node, IReceiver
    {
        public void recv(ISender s)
        {
            Console.WriteLine(name + " is receiving");
        }
        public Client(string name) : base(name) {}
    }

    class Program
    {
        static void Main(string[] args)
        {
            PeerToPeer peerToPeer1= new PeerToPeer("Torrent");
            PeerToPeer peerToPeer2 = new PeerToPeer("PTP2");
            Server server= new Server("SERVER");
            Client client = new Client("CLIENT");

            client.recv(server);
            client.recv(peerToPeer1);

            server.send(client);
            // client.recv(client);
            peerToPeer2.send(peerToPeer1);
            peerToPeer2.recv(peerToPeer1);

            Console.ReadKey();

        }
    }
}
