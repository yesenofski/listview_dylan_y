using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        public ObservableCollection<Dinner> Dishes { get; set; }

        public Page1 ()
		{
            
            Dishes = new ObservableCollection<Dinner>();
            ListView listView = new ListView();

            listView.RowHeight = 60;

            this.Title = "List View";
            listView.ItemTemplate = new DataTemplate(typeof(CustomDinnerCell));

            Dishes.Add(new Dinner
            {
                Dish = "Spaghetti",
                Recipe = "angel hair & Tomato sauce",
                Image = "http://icons.iconarchive.com/icons/icons-land/3d-food/256/Dish-Pasta-Spaghetti-icon.png"
            });

            Dishes.Add(new Dinner
            {
                Dish = "clambake",
                Recipe = "lobster, corn and clambs",
                Image = "https://hauteliving.com/wp-content/uploads/2016/03/C4F4816C-077D-4539-897D-33C3EA75638B.png"
            });

            Dishes.Add(new Dinner
            {
                Dish = "Teryaki Chicken",
                Recipe = "seasoned chicken and rice",
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSgsTvvyYt9L1P37BiSnbE9LSDeaRjeaIVvhH4cHzp5scRAWjqR"
            });

            Dishes.Add(new Dinner
            {
                Dish = "ceasar salad",
                Recipe = "lettuce and ceasar dressing",
                Image = "https://banner2.kisspng.com/20180526/lcv/kisspng-caesar-salad-fattoush-spinach-salad-israeli-salad-ceasar-salad-5b09c9e4ab2233.778219091527368164701.jpg"
            });

            Dishes.Add(new Dinner
            {
                Dish = "sushi",
                Recipe = "cali roll",
                Image = "https://hdyr.files.wordpress.com/2012/09/cali-roll-shot-1.jpg"
            });


            listView.ItemsSource = Dishes;
            Content = listView;

        }
        public class CustomDinnerCell:ViewCell 
        {
            public CustomDinnerCell()
            {
                var Image = new Image();
                var dishLabel = new Label();
                var recipeLabel = new Label();
                var verticaLayout = new StackLayout();
                var horizontalLayout = new StackLayout() { BackgroundColor = Color.Transparent  };



                dishLabel.SetBinding(Label.TextProperty, new Binding("Dish"));
                dishLabel.SetBinding(Label.TextProperty, new Binding("Dish"));
                recipeLabel.SetBinding(Label.TextProperty, new Binding("Recipe"));
                recipeLabel.SetBinding(Label.TextProperty, new Binding("Recipe"));
                Image.SetBinding(Image.SourceProperty, new Binding("Image"));
                Image.SetBinding(Image.SourceProperty, new Binding("Image"));
                dishLabel.FontSize = 24;

                Image.HorizontalOptions = LayoutOptions.Start;

                horizontalLayout.Orientation = StackOrientation.Horizontal;
                horizontalLayout.HorizontalOptions = LayoutOptions.Fill;
                horizontalLayout.Children.Add(verticaLayout);
                horizontalLayout.Children.Add(Image);



                verticaLayout.Children.Add(dishLabel);
                verticaLayout.Children.Add(recipeLabel);
              

              
                View = horizontalLayout;





            }

            
        }
    }

    
}