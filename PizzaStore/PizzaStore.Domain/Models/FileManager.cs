using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PizzaStore.Domain.Models
{
  public class FileManager
  {
    //XML = extensible markup language

    private const string _path = @"data/pizza_store.xml";

    public Order Read()
    {
      var reader = new StreamReader(_path);
      var xml = new XmlSerializer(typeof(Order));

      return xml.Deserialize(reader) as Order;
    }

    public void Write(Order order)
    {
      //create a file
      //open the file with write permissions
      //load content to write
      //convert content to xml
      //write xml to file
      //close the file

      var writer = new StreamWriter(_path);
      var xml = new XmlSerializer(typeof(Order));

      xml.Serialize(writer, order);
    }
  }
}