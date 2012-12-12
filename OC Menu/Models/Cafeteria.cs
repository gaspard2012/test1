/*
 Gaspard Mucundanyi
 Robert Rugamba
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Web;

namespace OC_Menu.Models
{
    public class Cafeteria
    {
        // here are the public properties
        public List<Item> Items_List { get; set; }
        public List<Line> Line_List { get; set; }

        // Declare a constructor
        public Cafeteria()
        {  
            List<Item> Items_List = new List<Item>();
            List<Line> Line_List = new List<Line>();
        }

        // Method 1. For reading Breakfast xml file
        public List<Line> Breakfast()
        {
            string xmlURL = "http://otmobapp.com/udapp/API_s/Breakfast.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlURL);

            XmlNode Line_Node = doc.SelectSingleNode("/Breakfast/Line");
            XmlNodeList LineNodeList = Line_Node.SelectNodes("Line");
            // create a new line list
            List<Line> lines = new List<Line>();
            foreach (XmlNode nodE in LineNodeList)
            {
                var line = new Line();
                // get the line details
                line.lineName = Line_Node.SelectSingleNode("LineName").InnerText;
                
                XmlNode item_Node = doc.SelectSingleNode("/Breakfast/item");
                XmlNodeList ItemNodeList = item_Node.SelectNodes("item");
                // create a list to handle list of items
                List<Item> itemsList = new List<Item>();
                foreach (XmlNode node in ItemNodeList)
                {
                    // populate the item content for that particular line.
                    var ITEM = new Item();
                    ITEM.itemName = node.Attributes.GetNamedItem("ItemName").Value;
                    ITEM.itemFood = node.Attributes.GetNamedItem("itemFood").Value;
                    ITEM.foodServingSize = node.Attributes.GetNamedItem("foodServingSize").Value;
                    ITEM.foodCalories = node.Attributes.GetNamedItem("foodCalories").Value;
                    ITEM.foodFat = node.Attributes.GetNamedItem("foodFat").Value;
                    ITEM.foodCholestoral = node.Attributes.GetNamedItem("foodCholestoral").Value;
                    ITEM.foodSodium = node.Attributes.GetNamedItem("foodSodium").Value;
                    ITEM.foodPottasium = node.Attributes.GetNamedItem("foodPottasium").Value;
                    ITEM.foodCarbohydate = node.Attributes.GetNamedItem("foodCarbohydrate").Value;
                    ITEM.foodProtein = node.Attributes.GetNamedItem("foodProtein").Value;
                  
                    // add the item now to the list of items
                    itemsList.Add(ITEM);
                }
                //then add that line onto the list of lines
                lines.Add(line);
            }
            return lines;
        }  // end of the breakfast method

        // Method 2. For reading the Lunch xml file
        public List<Line> Lunch()
        {
            string xmlURL = "http://otmobapp.com/udapp/API_s/Lunch.xml";
   
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlURL);

            List<Line> lines = new List<Line>();
            XmlNode Line_Node = doc.SelectSingleNode("/Lunch/Line");
            XmlNodeList LineNodeList = Line_Node.SelectNodes("Line");
            foreach (XmlNode node in LineNodeList)
            {
                var line = new Line();
                line.lineName = Line_Node.SelectSingleNode("LineName").InnerText;
                lines.Add(line);
            }

            return lines;
        } // end of the Lunch Method

        // Method 3. For reading the Dinner xml file
        public List<Line> Dinner()
        {
            string xmlURL = "http://otmobapp.com/udapp/API_s/Dinner.xml";
            
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlURL);

            List<Line> lines = new List<Line>();
            XmlNode Line_Node = doc.SelectSingleNode("/Dinner/Line");
            XmlNodeList LineNodeList = Line_Node.SelectNodes("Line");
            foreach (XmlNode node in LineNodeList)
            {
                var line = new Line();
                line.lineName = Line_Node.SelectSingleNode("LineName").InnerText;
                lines.Add(line);
            }

            return lines;
        } // End of the Dinner Method. 

    }
        // Class Item:
       public class Item
        {
            // Here are the public properties for the class
            public string itemName { get; set; }
            public string itemFood { get; set; }
            public string foodServingSize { get; set; }
            public string foodCalories { get; set; }
            public string foodFat { get; set; }
            public string foodCholestoral { get; set; }
            public string foodPottasium { get; set; }
            public string foodSodium { get; set; }
            public string foodCarbohydate { get; set; }
            public string foodProtein { get; set; }

            // Declare a constructor 
            public Item()
            { }
        }

       // Class Line:
       public class Line
       {
           // Here are the properties for the class
           public string lineName { get; set; }
           public List<Line> Line_List { get; set; }


           // Class constructor
           public Line()
           {
               List<Line> Lines = new List<Line>();
           }
       }
}
























                    //ITEM.itemName = ItemList.SelectSingleNode("ItemName").InnerText;
                    //ITEM.itemFood = ItemList.SelectSingleNode("ItemFood").InnerText;
                    //ITEM.foodServingSize = ItemList.SelectSingleNode("foodServingSize").InnerText;
                    //ITEM.foodCalories = ItemList.SelectSingleNode("foodCalories").InnerText;
                    //ITEM.foodFat = ItemList.SelectSingleNode("foodFat").InnerText;
                    //ITEM.foodCholestoral = ItemList.SelectSingleNode("foodCholestoral").InnerText;
                    //ITEM.foodSodium = ItemList.SelectSingleNode("foodSodium").InnerText;
                    //ITEM.foodPottasium = ItemList.SelectSingleNode("foodPottasium").InnerText;
                    //ITEM.foodCarbohydate = ItemList.SelectSingleNode("foodCarbohydrate").InnerText;
                    //ITEM.foodProtein = ItemList.SelectSingleNode("foodProtein").InnerText;


/*

<table>
    <tr>
       <td>
          @Html.DisplayNameFor(model => model.Breakfast);
       </td>
       <td>
          @Html.DisplayNameFor(model => model.Lunch);
       </td>
       <td>
          @Html.DisplayNameFor(model => model.Dinner);
       </td>
    </tr>
</table> */




























