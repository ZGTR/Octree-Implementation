using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using Octree_ZGTR_WPFApp;

using Octree_ZGTR_WPFApp.Engine.OctreeTree;
using Octree_ZGTR_WPFApp.Engine.OctreeTree.OctreeTypes.AbstractOctree;
using Octree_ZGTR_WPFApp.Engine.OctreeTree.OctreeTypes.UnBalanced;

namespace ConsoleApplicationTest_Octree
{
    public class Program
    {
        public static Octree octree;
        [STAThread]
        static void Main(string[] args)
        {
            //int i = ImageController.GetNumColorsOfImage("Flower1.jpg");

            DateTime t1 = DateTime.Now;
            octree = new OctreeUnBalancedLeastV1SideCollapsing(256);
            octree.BuildOctreeFromImageFile("1.jpg");

            DateTime t2 = DateTime.Now;
            double period1 = (t2 - t1).TotalSeconds;    

            Console.Write(@"Done parsing with time = ");
            Console.WriteLine(period1);

            

            Console.WriteLine(@"Retiving picture..");
            DateTime t3 = DateTime.Now;

            var colorTable = new ColorTable(octree);        
            colorTable.BuildColorTable();

            DateTime t4 = DateTime.Now;
            double period2 = (t4 - t3).TotalSeconds;

           
            Console.Write(@"Done retiving with time = ");
            Console.WriteLine(period2);
            Console.WriteLine((t4 - t3).TotalMinutes);
            Console.Write(@"Total Time = ");
            Console.WriteLine(period1 + period2);
            Console.WriteLine(@"Done Everything!");
            Console.WriteLine(@"Time under investegating is = " + Octree.TotalTimeCollapse);
        }
    }
}
 
