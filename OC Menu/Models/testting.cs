//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Xml;
//using System.Web;

//namespace OC_Menu.Models
//{
//    public static class testting
//    {
//        /*---------BREAKFAST-------------*/
        
//        private static string xmlURL = "http://otmobapp.com/udapp/API_s/Breakfast.xml";
        
//         Parse the xml using the XMLDocument class
//        public static Cafeteria ParseByXMLDocument()
//        {
//            var menu = new Cafeteria();

//            XmlDocument doc = new XmlDocument();
//            doc.Load(xmlURL);

//            XmlNode LineNode = doc.SelectSingleNode("/Breakfast/Line");
//            foreach (XmlNode nodE in LineNode)
//            {
//                 create line object
//                var LINE = new line();
//                 get the line details
//                LINE.line_num = LineNode.SelectSingleNode("Line").InnerText;
               
//                XmlNode ItemList = doc.SelectSingleNode("/Breakfast/item");
//                foreach (XmlNode node in ItemList)
//                {
//                     populate the item content for that particular line.
//                    var ITEM = new Item();
//                    ITEM.itemName = ItemList.SelectSingleNode("ItemName").InnerText;
//                    ITEM.itemFood = ItemList.SelectSingleNode("ItemFood").InnerText;
//                    ITEM.foodServingSize = ItemList.SelectSingleNode("foodServingSize").InnerText;
//                    ITEM.foodCalories = ItemList.SelectSingleNode("foodCalories").InnerText;
//                    ITEM.foodFat = ItemList.SelectSingleNode("foodFat").InnerText;
//                    ITEM.foodCholestoral = ItemList.SelectSingleNode("foodCholestoral").InnerText;
//                    ITEM.foodSodium = ItemList.SelectSingleNode("foodSodium").InnerText;
//                    ITEM.foodPottasium = ItemList.SelectSingleNode("foodPottasium").InnerText;
//                    ITEM.foodCarbohydate = ItemList.SelectSingleNode("foodCarbohydrate").InnerText;
//                    ITEM.foodProtein = ItemList.SelectSingleNode("foodProtein").InnerText;

//                     add the item now to the list of items
//                    menu.ITEM_LIST.Add(ITEM);
//                }

//                then add that line onto the list of lines
//                menu.LINE_LIST.Add(LINE);
//            }
//            return menu;
//        }  
//        /*--------LUNCH--------------*/
//        /*
//         public static string xmlURL = "http://otmobapp.com/udapp/API_s/Lunch.xml";
//         Parse the xml using the XMLDocument class
//        public static Cafeteria ParseByXMLDocument()
//        {
//            var menu = new Cafeteria();
//            XmlDocument doc = new XmlDocument();
//            doc.Load(xmlURL);

//            var LINE = new line();
//            XmlNode LineNode = doc.SelectSingleNode("/Lunch/Line");
//            foreach (XmlNode node in LineNode)
//            {
//                LINE.line_num = LineNode.SelectSingleNode("LineName").InnerText;
//                menu.LINE_LIST.Add(LINE);
//            }
//            return menu;
//        }
//        */

//        /*--------DINNER--------------*/
//        /*
//        public static string xmlURL = "http://otmobapp.com/udapp/API_s/Dinner.xml";
//         Parse the xml using the XMLDocument class
//        public static Cafeteria ParseByXMLDocument()
//        {
//            var menu = new Cafeteria();
//            XmlDocument doc = new XmlDocument();
//            doc.Load(xmlURL);

//            var LINE = new line();
//            XmlNode LineNode = doc.SelectSingleNode("/Dinner/Line");
//            foreach (XmlNode node in LineNode)
//            {
//                LINE.line_num = LineNode.SelectSingleNode("LineName").InnerText;
//                menu.LINE_LIST.Add(LINE);
//            }
//            return menu;
//        }
//        */
//    }
//}