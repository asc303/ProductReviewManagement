using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Program");
            List<ProductReview> productList = new List<ProductReview>
            {
                new ProductReview() { ProductID = 1, UserID = 32, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() { ProductID = 5, UserID = 56, Rating = 3, Review = "Better", IsLike = true},
                new ProductReview() { ProductID = 86, UserID = 71, Rating = 2, Review = "Poor", IsLike = false},
                new ProductReview() { ProductID = 5, UserID = 99, Rating = 5, Review = "Great", IsLike = true},
                new ProductReview() { ProductID = 66, UserID = 44, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() { ProductID = 7, UserID = 80, Rating = 3, Review = "Better", IsLike = true},
                new ProductReview() { ProductID = 4, UserID = 71, Rating = 5, Review = "Great", IsLike = true},
                new ProductReview() { ProductID = 56, UserID = 76, Rating = 1, Review = "Bad", IsLike = false},
                new ProductReview() { ProductID = 88, UserID = 32, Rating = 2, Review = "Poor", IsLike = false},
                new ProductReview() { ProductID = 9, UserID = 47, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() { ProductID = 9, UserID = 10, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() { ProductID = 30, UserID = 10, Rating = 3, Review = "Better", IsLike = true},
                new ProductReview() { ProductID = 20, UserID = 10, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() { ProductID = 1, UserID = 10, Rating = 5, Review = "Great", IsLike = true},
                new ProductReview() { ProductID = 89, UserID = 10, Rating = 2, Review = "Poor", IsLike = false}
            };
            bool flag = true;
            Management management = new Management();
            while (flag)
            {
                Console.WriteLine("Enter the Program that you want to be executed : \n 1. Displaying of Products List \n 2. Top 3 Rated Records \n 3. Retrieve Records using Product ID of Rating > 3 \n 4. Number of Records for Product ID \n 5. Retrieve ProductId and Review for all records \n 6. Skip Top 5 and Display \n 7. Retrieve ProductId and Review for all records \n 8. Creation and Insertion of Values in DataTable \n 9. Retrieve Records Whose Islike is True \n 10. Average Rating Per ProductId \n 11. Retrieve Records of given Review message \n 12. Retrieve Records using UserId \n 13. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        management.Display(productList);
                        break;
                    case 2:
                        management.TopThreeRatingRecords(productList);
                        break;
                    case 3:
                        management.RetrieveRecordsUsingProductId(productList);
                        break;
                    case 4:
                        management.RetrieveCountOfRecords(productList);
                        break;
                    case 5:
                        management.RetrieveOnlyProductIdAndReview(productList);
                        break;
                    case 6:
                        management.SkipTopFiveRecords(productList);
                        break;
                    case 7:
                        management.RetrieveOnlyProductIdAndReview(productList);
                        break;
                    case 8:
                        management.ProductReviewsDataTable(productList);
                        break;
                    case 9:
                        management.RetrieveRecordsFromDataTableWhoseIsLikeIsTrue();
                        break;
                    case 10:
                        management.AverageRatingPerProductId(productList);
                        break;
                    case 11:
                        management.RetrieveRecordsOfReviewMessage(productList, "Good");
                        break;
                    case 12:
                        management.RetrieveRecordsUsingUserId();
                        break;
                    case 13:
                        flag = false;
                        break;
                }
            }
        }
    }
}