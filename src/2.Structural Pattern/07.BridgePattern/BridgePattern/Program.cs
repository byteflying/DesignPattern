using System;

namespace BridgePattern {

    public class Program {

        private static TeleControllerBase _remoteControl = null;

        public static void Main(string[] args) {
            _remoteControl = new TeleController();

            _remoteControl.Television = new Konka();
            _remoteControl.TurnOn();
            _remoteControl.TurnChannel();
            _remoteControl.TurnOff();

            _remoteControl.Television = new Lenovo();
            _remoteControl.TurnOn();
            _remoteControl.TurnChannel();
            _remoteControl.TurnOff();

            _remoteControl.Television = new Panasonic();
            _remoteControl.TurnOn();
            _remoteControl.TurnChannel();
            _remoteControl.TurnOff();

            Console.ReadKey();
        }

    }

}