using System;

namespace Graph30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество вершины (введите готово, чтобы остановиться): ");
            Graph<string> graph = new Graph<string>();

            while (true)
            {
                string v = Console.ReadLine();
                if (v == "Выполнено")
                    break;
                graph.AddVertex(v);
            }

            Console.WriteLine("Введите края (введите готово, чтобы остановиться): ");
            while (true)
            {
                string v = Console.ReadLine();
                if (v == "Выполнено")
                    break;
                string w = Console.ReadLine();
                graph.AddEdge(v, w);
            }

            Console.WriteLine("Traversal: ");
            graph.Traverse();
        }
    }
}
/*
 напишу простую и короткую программу на си шарп для полного обхода графа с пользовательским вводом в консоль. 
Выведи класс Graph и точку входа. Оптимизируй программу так, чтобы не было повторного поиска через те же пути графа.
 */