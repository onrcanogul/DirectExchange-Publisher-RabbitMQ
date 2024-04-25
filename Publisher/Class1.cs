using RabbitMQ.Client;
using System.Text;

//Bağlantı oluşturma
ConnectionFactory factory = new();
factory.Uri = new("amqps://yejguzib:NuvHgMGxrkfxK8SHh3VRyAYLi3B3ENf1@shark.rmq.cloudamqp.com/yejguzib");

//Bağlantıyı aktifleştirme ve kanal açma
using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();


//Queue oluşturma
channel.QueueDeclare(queue: "example-queue",exclusive:false);

//Queue' a mesaj gönderme
//RabbitMQ kuyruga atacagı mesajları byte türünden kabul etmektedir.
byte[] message = Encoding.UTF8.GetBytes("merhaba");
channel.BasicPublish("", routingKey: "example-queue", body: message); //"" => default exchange


Console.Read();





            
    

