using System.Collections.Generic;
using BookGallery.Models;


namespace BookGallery.Services
{
    public class Data : IData
    {

        public List<Book> Books { get; set; }

        //constructor

        public Data()
        {
            Books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Name ="A Bend In The Road",
                    Description =" It tells the story of Miles Ryan, whose wife, Missy, was killed by a hit-and-run driver, and his attempt to move on from her loss.",
                    Author = "Nicholas Sparks",
                    ImageName = "bendintheroad.jpg"
                   
                },
                new Book()
                {
                    Id = 2,
                    Name ="Memoirs of a Geisha",
                    Description ="It tells the story of Nitta Sayuri and the many trials she faces on the path to becoming and working as a geisha in Kyoto, Japan, before, during and after World War II.",
                    Author = "Arthur Golden",
                    ImageName = "geisha.jpg"

                },
                new Book()
                {
                    Id = 3,
                    Name ="The Good Earth",
                    Description ="The Good Earth follows the life of Wang Lung from his beginnings as an impoverished peasant to his eventual position as a prosperous landowner.",
                    Author = "Pearl Buck",
                    ImageName = "goodearth.jpg"

                },
                new Book()
                {
                    Id = 4,
                    Name ="The House Girl",
                    Description =" A stunning debut novel of love, family, and justice that intertwines the stories of an escaped house slave in 1852 Virginia and ambitious young lawyer in contemporary New York",
                    Author = "Tara Conklin",
                    ImageName = "housegirl.jpg"

                },
                new Book()
                {
                    Id = 5,
                    Name ="The Hundred-Year Walk",
                    Description =" In the heart of the Ottoman Empire as World War I rages, Stepan Miskjian's world becomes undone. He is separated from his family as they are swept up in the government's mass deportation of Armenians into internment camps.",
                    Author = "Dawn Anahid MacKeen",
                    ImageName = "hundredyrwalk.jpg"

                },

                new Book()
                {
                    Id = 6,
                    Name ="In Order to Live",
                    Description ="Yeonmi Park was not dreaming of freedom when she escaped from North Korea. She didn't even know what it meant to be free. All she knew was that she was running for her life, that if she and her family stayed behind they would die - from starvation, or disease, or even execution",
                    Author = "Yeonmi Park",
                    ImageName = "inordertolive.jpg"

                },

                new Book()
                {
                    Id = 7,
                    Name ="The Kite Runner",
                    Description ="Tells the extraordinary story of an unlikely friendship between a wealthy Afghan boy, named Amir, and Hassan, the son of his father's servant — who he later finds out, after Hassan's death, has always been his half-brother.",
                    Author = "Khaled Hosseini",
                    ImageName = "kiterunner.jpg"
                },
                new Book()
                {
                    Id = 8,
                    Name ="The Boy in the Striped Pajamas",
                    Description ="Tells the story of Bruno, a young German boy growing up during World War II",
                    Author = " John Boyne",
                    ImageName = "stripedpaj.jpg"
                },
                new Book()
                {
                    Id = 9,
                    Name ="One Thousand White Women",
                    Description ="The story of May Dodd and a colorful assembly of pioneer women who, under the auspices of the U.S. government, travel to the western prairies in 1875 to intermarry among the Cheyenne Indians.",
                    Author = " Jim Fergus ",
                    ImageName = "thousandwomen.jpg"

                },
                new Book()
                {
                    Id = 10,
                    Name ="A Walk to Remember",
                    Description ="The story of an only son of a wealthy family that finds true love with the most unexpected person.",
                    Author = "Nicholas Sparks",
                    ImageName = "walktoremem.jpg"

                },
            };
        }


        public void AddBook(Book book)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBook(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Book GetBook(int? id)
        {
            if (id == null)
            {
                return null;

            }
            else
            {

                return Books.Find(x => x.Id == id);

            }
        }

        public List<Book> ReadAll()
        {
            return Books;
        }

        public void UpdateBook(Book book)
        {
            throw new System.NotImplementedException();
        }
    }
}







 