using System.Security.Cryptography;
using System.Text;

namespace demoAbstractedSystem
{
    abstract class Component
    {
        protected string type;
        protected int id;

        public override string ToString()
        {
            return type+" with id : "+id.ToString();
        }

        public Component(string type)
        {
            this.type = type;
        }

    }

    class Remote : Component, IRemote
    {

        public void off(IRemoteControlable rc)
        {
            rc.off();
        }

        public void on(IRemoteControlable rc)
        {
            rc.on();
        }


        public Remote(string name) : base(name)
        {
            HashAlgorithm algorithm = SHA256.Create();
            
            // gives the remote an ID
            id = algorithm.ComputeHash(Encoding.UTF8.GetBytes(name))[0];
        }
    }

    class Monitor : Component, IRemoteControlable 
    {

        public static int count = 0;
        bool active = false;

        public void off()
        {
            active = false;
        }

        public void on()
        {
            active = true;
        }

        public Monitor(string name) : base(name)
        {
            count++;
            id = count;
        }

        public override string ToString()
        {
            return base.ToString() + " is " + ( active ? "on" :"off" ) ;
        }
    }

    class PresentationRoom
    {
        Monitor monitor;
        Remote remote;
        public static int count = 0;
        int id;
        public PresentationRoom()
        {
            count++;
            id = count;
            monitor = new Monitor("Monitor from room "+id.ToString());
            remote = new Remote("Remote from room " + id.ToString());
        }

        public override string ToString()
        {
            return "PresentationRoom "+id.ToString()+"\n\t" 
                + monitor.ToString() + "\n\t" + remote.ToString() +"\n";
        }

        public void on()
        {
            remote.on(monitor);
        }
        public void off()
        {
            remote.off(monitor);
        }
    }

}
