using System;

namespace Principal
{
    class Aula36
    {
        static void Main()
        {
            var sensor = new SensorDeMovimento;
        }
    }
    public class SensorDeMovimento
    {
        public event EventHandler MovimentoDetectado;

        protected virtual void DetectarMovimento(EventArgs e)
        {
            EventHandler handler = MovimentoDetectado;
            handler?.Invoke(this, e);
        }


    }
}