using _06_RepositoryPatttern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class ProgramUI
    {
        private StreamingContentRepository _contentRepo = new StreamingContentRepository();
        //Method that starts the application UI
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //display options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content \n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");


                //get the user input
                string input = Console.ReadLine();

                //evaluate the user input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        //View
                        DisplayAllContent();
                        break;
                    case "3":
                        //View by Title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        //Update
                        UpdateExistingContent();
                        break;
                    case "5":
                        //Delete
                        DeleteExistingContent();
                        break;
                    case "6":
                        //Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid response between 1-6");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }


        }
        //Create new Streaming Content
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //title
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter the maturity rating for the content (G, PG, PG-13, etc): ");
            newContent.Rating = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the star count for the content (1.5, 10, 3.8, etc):");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //Is Family Friendly
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyAsString = Console.ReadLine().ToLower();
            if (familyFriendlyAsString == "y")
            {
                newContent.IsFamilyFriendly = true;

            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //Genre Type
            Console.WriteLine("Enter the Genre Number: \n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeofGenre = (GenreType)genreAsInt; //this is CAST

            _contentRepo.AddContentToList(newContent);


            /* Horror = 1,
            RomCom,
            SciFi,
            Documentary,
            Bromance,
            Drama,
            Action */

        }

        private void DisplayAllContent()
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _contentRepo.GetContentList();
            foreach (StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n");
            }
        }

        //View Content by Title
        private void DisplayContentByTitle()
        {
            Console.Clear();

            //Prompt the user for a title
            Console.WriteLine("Enter the title of the content that you would like to see: ");
            string title = Console.ReadLine();
            StreamingContent content = _contentRepo.GetContentByTitle(title);

            //Find the content by that title
            if(content != null)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                   $"Description: {content.Description}\n" +
                   $"Maturity Rating: {content.Rating}\n" +
                   $"Stars: {content.StarRating}\n" +
                   $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                   $"Genre: {content.TypeofGenre}");
                
            }
            else
            {
                Console.WriteLine("No content by that title.");
              
            }

            //Display content if not null
        }
        //update existing content
        private void UpdateExistingContent()
        {
            //Display all content
            DisplayAllContent();

            //Ask for the title of the content to update
            Console.WriteLine("Enter the title of the content that you widh to update:\n");
           
            //Get that title
            string oldTitle = Console.ReadLine();
            //build a new object
            StreamingContent newContent = new StreamingContent();

            //title
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter the maturity rating for the content (G, PG, PG-13, etc): ");
            newContent.Rating = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the star count for the content (1.5, 10, 3.8, etc):");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //Is Family Friendly
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyAsString = Console.ReadLine().ToLower();
            if (familyFriendlyAsString == "y")
            {
                newContent.IsFamilyFriendly = true;

            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //Genre Type
            Console.WriteLine("Enter the Genre Number: \n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeofGenre = (GenreType)genreAsInt; //this is CAST

            bool wasUpdated = _contentRepo.UpdateExistingContent(oldTitle, newContent);

            if (wasUpdated)
            {
                Console.WriteLine("Content was successfully updated.");

            }
            else
            {
                Console.WriteLine("Content could not be udpated.");
            }


        }
        //Delete
        private void DeleteExistingContent()
        {
            //Console.Clear(); this is already in the DisplayAllContent method

            //display the content to the user
            DisplayAllContent();

            //get the title that it to be deleted
            Console.WriteLine("\nEnter the title you wish to remove: ");
            string input = Console.ReadLine();
            //Call the delete method
            bool wasDeleted = _contentRepo.RemoveContentList(input);
            
            //if the content was deleted, say so. Otherise state that it could not be deleted.
            if (wasDeleted)
            {
                Console.WriteLine("Content was successfully removed.");
            }

            else
            {
                Console.WriteLine("Content could not be deleted.");
            }
            
        }

        //Seed Method

        private void SeedContentList()
        {
                      
                StreamingContent jaws = new StreamingContent("Jaws", "Scary shark movie", "PG", 8.0, false, GenreType.Drama);
                StreamingContent dieHard = new StreamingContent("Die Hard", "The best Die Hard movie", "R", 8.2, false, GenreType.Action);
                StreamingContent silenceOfLambs = new StreamingContent("The Silence of the Lambs", "Hello, Clarice", "R", 8.6, false, GenreType.Horror);
                
                _contentRepo.AddContentToList(jaws);
                _contentRepo.AddContentToList(dieHard);
                _contentRepo.AddContentToList(silenceOfLambs);
            
        }


    }
}
