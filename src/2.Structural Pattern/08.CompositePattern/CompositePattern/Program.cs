using System;

namespace CompositePattern {

    public class Program {

        public static void Main(string[] args) {
            try {
                var root = new Folder("Root");

                var music = new Folder("My Music");
                music.Attach(new File("Heal the world.mp3"))
                     .Attach(new File("When You Say Nothing At All.mp3"))
                     .Attach(new File("Long Long Way to Go.mp3"))
                     .Attach(new File("Beautiful In White.mp3"));

                var video = new Folder("My Video");
                video.Attach(new File("The Shawshank Redemption.avi"))
                     .Attach(new File("Schindler's List.avi"))
                     .Attach(new File("Brave Heart.avi"));

                var png = new File("missing.png");
                root.Attach(png)
                    .Detach(png)
                    .Detach(png);

                root.Attach(new File("readme.txt"))
                    .Attach(new File("index.html"))
                    .Attach(new File("file.cs"))
                    .Attach(music)
                    .Attach(video)
                    .Print();

                png.Attach(new File("error.json"));

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

    }

}