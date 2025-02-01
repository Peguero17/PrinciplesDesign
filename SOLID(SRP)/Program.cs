 class program
{
    public class NotificationService
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine("Enviando Email a: " + email);
            Console.WriteLine("Enviando mensaje: " + message);
        }
        public void SendSms(string PhoneNumber, string message) 
        {
            Console.WriteLine("Enviando SMS a: " + PhoneNumber);
            Console.WriteLine("Enviando mensaje: " + message);
        }
    }
    public class LogsMessages
    {
       public void message()
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine( timestamp + " Notificacion Registrada");
        }
    }
    public class SaltoLinea
    {
        public void LineaEnBlanco()
        {
            Console.WriteLine(" ");
        }
    }
    static void Main(string[] args)
    {

        bool menu = true;

        while (menu) {
            Console.WriteLine("Menu de Opciones: ");
            Console.WriteLine(" 1- Enviar Email");
            Console.WriteLine(" 2- Enviar SMS");
            Console.WriteLine(" 3- Salir del sistema ");
            Console.Write("   Elija lo que quiere hacer >>>");

            int opc = int.Parse(Console.ReadLine());

            LogsMessages log = new LogsMessages();

            NotificationService notification = new NotificationService();   

            SaltoLinea saltoLinea = new SaltoLinea();

            switch (opc) { 
                case 1:
                    Console.Write("Introduzca el Email del destinatario: ");
                    string correo = Console.ReadLine();
                    Console.Write("Introduzca el mensaje a enviar: ");
                    string mensaje = Console.ReadLine();
                    saltoLinea.LineaEnBlanco();
                    notification.SendEmail(correo, mensaje);
                    log.message();
                    saltoLinea.LineaEnBlanco();
                    break;
                case 2:
                    Console.Write("Introduzca el numero de telefono del destinatario: ");
                    string num = Console.ReadLine();
                    Console.Write("Introduzca el mensaje a enviar: ");
                    string sms = Console.ReadLine();
                    saltoLinea.LineaEnBlanco();
                    notification.SendSms(num, sms);
                    log.message();
                    saltoLinea.LineaEnBlanco();
                    break;
                case 3:
                    menu = false;
                    break;
                default:
                    Console.WriteLine("Ingresa una opcion valida");
                    break;
            }
        }
    }
}

