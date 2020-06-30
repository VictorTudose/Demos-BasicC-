using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoAbstractedSystem
{

    public interface IRemoteControlable
    {
        void on();
        void off();
    }

    public interface IRemote
    {
        void on(IRemoteControlable rc);
        void off(IRemoteControlable rc);
    }

}
