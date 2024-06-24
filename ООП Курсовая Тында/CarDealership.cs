using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ООП_Курсовая_Тында
{
    /// <summary>
    /// класс БД
    /// </summary>
    internal class CarDealership
    {
        /// <summary>
        /// список со всеми машинами
        /// </summary>
        List<Car> cars;
        /// <summary>
        /// Возвращает список машин
        /// </summary>
        /// <returns> список машин</returns>
        public List<Car> GetCars() { return cars; }
        /// <summary>
        /// список клиентов
        /// </summary>
        List<Client> clients;
        /// <summary>
        /// Возвращает список клиентов
        /// </summary>
        /// <returns>список клиентов</returns>
        public List<Client> GetClients() {  return clients; }
        /// <summary>
        /// Инициализирует класс <see cref="CarDealership"/> class.
        /// </summary>
        public CarDealership()
        {
            cars = new List<Car>();
            clients = new List<Client>();
        }
        /// <summary>
        /// Сохраняет по пути
        /// </summary>
        /// <param name="path">путь к файлу</param>
        public void Save(string path)
        {
            TextWriter? writer = null;
            try
            {
                writer = new StreamWriter(path);
                var books = JsonSerializer.Serialize(cars, Context.Default.ListCar);
                var client = JsonSerializer.Serialize(clients, Context.Default.ListClient);
                writer.Write(books + "\n" + client);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
        /// <summary>
        /// загружает БД по пути
        /// </summary>
        /// <param name="path">путь к файлу</param>
        public void Load(string path) 
        {
            TextReader? reader = null;
            try
            {
                reader = new StreamReader(path);
                if (reader == null) throw new ArgumentNullException();
                string? tmpLineCar = reader.ReadLine();
                string? tmpLineClient = reader.ReadLine();
                if (tmpLineCar == null || tmpLineClient == null) throw new ArgumentNullException();
                List<Car>? film = JsonSerializer.Deserialize<List<Car>>(tmpLineCar);
                List<Client>? afish = JsonSerializer.Deserialize<List<Client>>(tmpLineClient);
                if (film == null || afish == null) throw new ArgumentNullException();
                cars = film;
                clients = afish;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

    }
    /// <summary>
    /// запись машины
    /// </summary>
    /// <seealso cref="System.IEquatable&lt;ООП_Курсовая_Тында.Car&gt;" />
    record Car
    (
        string _number,
        string _mark,
        int _volume,
        int _sit,
        int _cost,
        string _year
    );
    /// <summary>
    /// запись клиента
    /// </summary>
    /// <seealso cref="System.IEquatable&lt;ООП_Курсовая_Тында.Client&gt;" />
    record Client
        (
        string _name,
        string _carnumber,
        string _post
        );

    [JsonSerializable(typeof(List<Car>))]
    [JsonSerializable(typeof(List<Client>))]
    internal partial class Context : JsonSerializerContext
    {
    }
}
