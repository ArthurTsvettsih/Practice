using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DataSets.Implementations.Graphs
{
    public class GraphPractice
    {
        public void HowToCreateAGraph()
        {
            var theWeb = new Graph<string>();
            theWeb.AddNode("Privacy.htm");
            theWeb.AddNode("People.aspx");
            theWeb.AddNode("About.htm");
            theWeb.AddNode("Index.htm");
            theWeb.AddNode("Products.aspx");
            theWeb.AddNode("Contact.aspx");

            theWeb.AddDirectedEdge("People.aspx", "Privacy.htm");

            theWeb.AddDirectedEdge("Privacy.htm", "Index.htm");
            theWeb.AddDirectedEdge("Privacy.htm", "About.htm");

            theWeb.AddDirectedEdge("About.htm", "Privacy.htm");
            theWeb.AddDirectedEdge("About.htm", "People.aspx");
            theWeb.AddDirectedEdge("About.htm", "Contact.aspx");

            theWeb.AddDirectedEdge("Index.htm", "About.htm");
            theWeb.AddDirectedEdge("Index.htm", "Contact.aspx");
            theWeb.AddDirectedEdge("Index.htm", "Products.aspx");

            theWeb.AddDirectedEdge("Products.aspx", "Index.htm");
            theWeb.AddDirectedEdge("Products.aspx", "People.aspx");
        }
    }
}
