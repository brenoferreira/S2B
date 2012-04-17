using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    interface Usb
    {
        void Conectar();

        void Desconectar();

        void ExecutarAcao();
    }

    class Mouse : Usb
    {
        public void Conectar()
        {
            Console.WriteLine("Mouse conectado");
        }

        public void Desconectar()
        {
            Console.WriteLine("Mouse desconectado");
        }

        public void ExecutarAcao()
        {
            Console.WriteLine("Mouse moveu de posição");
        }
    }

    class Celular : Usb
    {
        public void Conectar()
        {
            Console.WriteLine("Celular conectado a usb");
        }

        public void Desconectar()
        {
            Console.WriteLine("celular desconectado usb");
        }

        public void ExecutarAcao()
        {
            Console.WriteLine("Carregando a bateria do celular");
        }
    }

    class SO
    {
        private Usb dispositivo;
        public void ConectarDispositivoUsb(Usb dispositivoUsb)
        {
            this.dispositivo = dispositivoUsb;
            this.dispositivo.Conectar();
        }

        public void DesconectarDispositivoUsb()
        {
            this.dispositivo.Desconectar();
        }

        public void UsarDispositivo()
        {
            this.dispositivo.ExecutarAcao();
        }
    }

    interface AcessoBD
    {
        void Inserir(int x);

        void Atualizar(int x);

        void Deletar(int x);

        int Selecionar();
    }

    class AcessoBDSqlServer : AcessoBD
    {
        public void Inserir(int x)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(int x)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int x)
        {
            throw new NotImplementedException();
        }

        public int Selecionar()
        {
            throw new NotImplementedException();
        }
    }

    class AcessoBDOracle : AcessoBD
    {

        void AcessoBD.Inserir(int x)
        {
            throw new NotImplementedException();
        }

        void AcessoBD.Atualizar(int x)
        {
            throw new NotImplementedException();
        }

        void AcessoBD.Deletar(int x)
        {
            throw new NotImplementedException();
        }

        int AcessoBD.Selecionar()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SO windows = new SO();
            Usb dispositivoUsb = new Mouse();

            windows.ConectarDispositivoUsb(dispositivoUsb);
            windows.UsarDispositivo();
            windows.DesconectarDispositivoUsb();

            dispositivoUsb = new Celular();

            windows.ConectarDispositivoUsb(dispositivoUsb);
            windows.UsarDispositivo();
            windows.DesconectarDispositivoUsb();

            Console.ReadKey();
        }
    }
}
