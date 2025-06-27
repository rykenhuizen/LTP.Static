using LTP.Static.Models;

namespace LTP.Static.Data
{
    public static class MenuData
    {
        public static MenuCatagory[] GetMenu()
        {
            return
            [
                GetPizza(),
                GetGarlicFingers(),
                GetDonair(),
                GetPoutine(),
                GetExtras(),
                GetChicken(),
                GetFish(),
                GetSalads(),
                GetPanzerotti(),
                GetWraps(),
                GetSalads(),
                GetNachos(),
                GetIcecream(),
                GetDesserts(),
            ];
        }

        public static MenuCatagory GetIcecream()
        {
            var icecream = new MenuCatagory()
            {
                Name = "Icecream",
                Sizes = ["", "Add Waffle"],
                Pictures = ["Icecream1.jpg", "Icecream2.jpg"],
                Items =
                [
                    new MenuItem
                    {
                        Name = "Kiddy",
                        Price = [3.90, 1]
                    },
                    new MenuItem
                    {
                        Name = "Regular",
                        Price = [4.95,1]
                    },
                    new MenuItem
                    {
                        Name = "Large",
                        Price = [5.96,1]
                    },
                    new MenuItem
                    {
                        Name = "Milkshake",
                        Price = [7.69]
                    },
                ]
            };
            return icecream;
        }

        public static MenuCatagory GetNachos()
        {
            var nachos = new MenuCatagory()
            {
                Name = "Nachos",
                Items =
                [
                    new MenuItem
                    {
                        Price = [22.99]
                    },
                    new MenuItem
                    {
                        Name = "Add Chicken/Donair Meat",
                        Price = [3.99]
                    },
                    new MenuItem
                    {
                        Name = "Extra Cheese",
                        Price = [3.99]
                    },
                ]
            };
            return nachos;
        }
        public static MenuCatagory GetSubs()
        {
            var subs = new MenuCatagory()
            {
                Name = "Subs",
                Options = [ "Cold Cut",
                            "Pizza",
                            "Veggie",
                            "Chicken Burschetta",
                            "Donair"],
                Items =
                [
                    new MenuItem
                    {
                        Price = [12.99]
                    },
                ]
            };
            return subs;
        }
        public static MenuCatagory GetWraps()
        {
            var wraps = new MenuCatagory()
            {
                Name = "Wraps",
                Options = [ "Chicken Ceasar",
                            "Veggie",
                            "Shawarma Wrap"],
                Items =
                [
                    new MenuItem
                    {
                        Price = [12.99]
                    },
                ]
            };
            return wraps;
        }
        public static MenuCatagory GetPanzerotti()
        {
            var panzerotti = new MenuCatagory()
            {
                Name = "Panzerotti",
                Options = [ "Pepperoni",
                            "Hawaiian",
                            "Works",
                            "Donair",
                            "BBQ Chicken",
                            "Brothers Pepperoni",
                            "Meat Lovers",
                            "Veggie"],
                Items =
                [
                    new MenuItem
                    {
                        Price = [15.99]
                    },
                ]
            };
            return panzerotti;
        }

        public static MenuCatagory GetDonair()
        {
            var donairs = new MenuCatagory()
            {
                Name = "Donairs",
                Sizes = ["", "Add Cheese"],
                Pictures = ["Donair.jpg", "DonairRolls.jpg"],
                Items =
                [
                    new MenuItem
                    {
                        Name = "Regular",
                        Price = [10.99,2.5]
                    },
                    new MenuItem
                    {
                        Name = "Large",
                        Price = [13.99,3.00]
                    },
                    new MenuItem
                    {
                        Name = "Extra Large",
                        Price = [15.99,3.5]
                    },
                    new MenuItem
                    {
                        Name = "Donair Plate",
                        Price = [15.99]
                    },
                    new MenuItem
                    {
                        Name = "Donair Egg Rolls (4pc)",
                        Price = [8.99]
                    },
                    new MenuItem
                    {
                        Name = "Donair Egg Rolls (6pc)",
                        Price = [12.99]
                    },
                    new MenuItem
                    {
                        Name = "Donair Egg Rolls (8pc)",
                        Price = [14.99]
                    },
                    new MenuItem
                    {
                        Name = "Donair Egg Rolls (12pc)",
                        Price = [19.99]
                    },
                ]
            };
            return donairs;
        }

        public static MenuCatagory GetFish()
        {
            var fish = new MenuCatagory()
            {
                Name = "Fish 'n' Chips",
                Items =
                [
                    new MenuItem
                    {
                        Name = "2 pc",
                        Price = [14.99]
                    },
                    new MenuItem
                    {
                        Name = "3 pc",
                        Price = [16.99]
                    },
                    new MenuItem
                    {
                        Name = "Family Pack (8pc and 2 large fries)",
                        Price = [42.95]
                    },
                ]
            };
            return fish;
        }
        public static MenuCatagory GetDesserts()
        {
            var desserts = new MenuCatagory()
            {
                Name = "Desserts",
                Pictures = ["Dessert.jpg"],
                Items =
                [
                    new MenuItem
                    {
                        Name = "Cheesecake: Blueberry, Colcolate, Strawberry, Lemon, Cherry, Carmel",
                        Price = [8.99]
                    },
                    new MenuItem
                    {
                        Name = "Double Fudge Brownies",
                        Price = [7.99]
                    },
                    new MenuItem
                    {
                        Name = "Date Squares",
                        Price = [7.99]
                    },
                ]
            };
            return desserts;
        }

        public static MenuCatagory GetChicken()
        {
            var chicken = new MenuCatagory()
            {
                Name = "Chicken",
                OptionName = "Sauce Choices",
                Options = ["Mild", "Medium", "Hot", "Honey Garlic", "BBQ"],
                Items =
                [
                    new MenuItem
                    {
                        Name = "2 pc meal",
                        Price = [13.99]
                    },
                    new MenuItem
                    {
                        Name = "3 pc meal",
                        Price = [14.99]
                    },
                    new MenuItem
                    {
                        Name = "Family Pack",
                        Price = [42.95]
                    },
                    new MenuItem
                    {
                        Name = "Chicken Strips (4pc)",
                        Price = [12.99]
                    },
                    new MenuItem
                    {
                        Name = "Chicken Strips (6pc)",
                        Price = [14.99]
                    },
                    new MenuItem
                    {
                        Name = "Wings (10 pc)",
                        Price = [14.99]
                    },
                    new MenuItem
                    {
                        Name = "Wings (20 pc)",
                        Price = [26.99]
                    },
                    new MenuItem
                    {
                        Name = "Wings (30 pc)",
                        Price = [36.99]
                    },
                    new MenuItem
                    {
                        Name = "Wings (50 pc)",
                        Price = [52.99]
                    },
                ]
            };
            return chicken;
        }

        private static MenuCatagory GetExtras()
        {
            var extras = new MenuCatagory()
            {
                Name = "Extras",
                Items =
                [
                    new MenuItem
                    {
                        Name = "Onion Rings",
                        Price = [7.99]
                    },
                    new MenuItem
                    {
                        Name = "Fries",
                        Price = [6.99]
                    },
                    new MenuItem
                    {
                        Name = "Mozza Sticks (8pc)",
                        Price = [9.99]
                    },
                    new MenuItem
                    {
                        Name = "Mozza Sticks (12pc)",
                        Price = [12.99]
                    },
                ]
            };
            return extras;
        }

        private static MenuCatagory GetGarlicFingers()
        {
            var garlicFingers = new MenuCatagory()
            {
                Name = "Garlic Fingers",
                Sizes = ["Small 9\"", "Medium 12\"", "Large 16\"", "XLarge 18\""],
                Items =
                [
                    new MenuItem
                    {
                        Name = "",
                        Price = [12.99, 15.99, 19.99, 23.99]
                    },
                    new MenuItem
                    {
                        Name = "Add Bacon",
                        Price = [2.50, 3.00, 3.50, 4.00]
                    },
                 ]
            };
            return garlicFingers;
        }

        private static MenuCatagory GetSalads()
        {
            var salads = new MenuCatagory()
            {
                Name = "Salads",
                Sizes = ["", "Add Chicken"],
                Items =
                [
                    new MenuItem
                    {
                        Name = "Greek",
                        Price = [12.99, 4.00]
                    },
                    new MenuItem
                    {
                        Name = "Caesar",
                        Price = [12.99, 4.00]
                    },
                ]
            };
            return salads;
        }

        private static MenuCatagory GetPoutine()
        {

            var poutine = new MenuCatagory()
            {
                Name = "Poutine",
                Options = [ "Classic Poutine",
                            "Donair Poutine",
                            "Greek Poutine",
                            "Chicken Poutine",
                            "Hawaiian Poutine",
                ],
                Sizes = ["Regular", "Large"],
                Items =
                [
                   new MenuItem
                    {
                        Price = [9.99, 12.99]
                    },
                ],
            };
            return poutine;
        }

        private static MenuCatagory GetPizza()
        {
            var pizza = new MenuCatagory
            {
                Name = "Pizza",
                OptionName = "Toppings",
                Subtitle = "Turn any 12 inch pizza into gluten free crust add $4.99",
                Options = [ "Pepperoni",
                            "Donair Meat",
                            "Mushrooms",
                            "Salami",
                            "Pineapple",
                            "Green Pepper",
                            "Bacon",
                            "Green Olives",
                            "Onions",
                            "Ground Beef",
                            "Black Olives",
                            "Tomato",
                            "Italian Sausage",
                            "Hot Peppers",
                            "Ham" ],
                Pictures = [ "Pizza.jpg", "PizzaSlice.jpg",],
                Sizes = ["Small 9\"", "Medium 12\"", "Large 16\"", "XLarge 18\""],
                Items =
                [
                    new MenuItem
                    {
                        Name = "Cheese",
                        Price = [11.99, 16.99, 20.99, 26.99]
                    },
                    new MenuItem
                    {
                        Name = "1 Item",
                        Price = [12.99, 17.99, 21.99, 27.99]
                    },
                    new MenuItem
                    {
                        Name = "2 Item",
                        Price = [13.49, 18.99, 22.99, 28.99]
                    },
                    new MenuItem
                    {
                        Name = "3 Item",
                        Price = [13.99, 19.99, 23.99, 29.99]
                    },
                    new MenuItem
                    {
                        Name = "4 Item",
                        Price = [14.49, 20.99, 24.99, 30.99]
                    },
                    new MenuItem
                    {
                        Name = "5 Item",
                        Price = [14.99, 21.49, 25.99, 31.99]
                    },
                    new MenuItem
                    {
                        Name = "Extra Cheese",
                        Price = [2.00, 2.75, 3.75, 4.75]
                    },
                    new MenuItem
                    {
                        Name = "Canadian Classic",
                        Description = "Canadian classic: pepperoni, mushrooms, bacon mozzarella",
                        Price = [13.99, 19.99, 23.99, 29.99]
                    },
                    new MenuItem
                    {
                        Name = "Brothers Peperoni",
                        Description = "Brothers pepperoni: mild cut up pepperoni made by brothers",
                        Price = [13.49, 18.99, 22.99, 28.99]
                    },
                    new MenuItem
                    {
                        Name = "Vegetarian",
                        Description = "Vegetarian: onions, mushrooms. green peppers, tomatoes, pineapple, green olives, mozzarella Greek",
                        Price = [15.49, 21.99, 26.99, 32.99]
                    },
                    new MenuItem
                    {
                        Name = "Works",
                        Description = "Works: pepperoni, salami, bacon, ground beef, mushrooms, green peppers, onions, mozzarella",
                        Price = [15.49, 21.99, 26.99, 32.99]
                    },
                    new MenuItem
                    {
                        Name = "Donair",
                        Description = "Donair: donair meat, onions, tomatoes, mozzarella",
                        Price = [15.49, 21.99, 26.99, 32.99]
                    },
                    new MenuItem
                    {
                        Name = "Greek",
                        Description = "Greek: black olives, red onions, tomatoes, oregano, olive oil, mozzarella, feta",
                        Price = [15.49, 21.99, 26.99, 32.99]
                    },
                    new MenuItem
                    {
                        Name = "Hawaiian",
                        Description = "Hawaiian: bacon, ham, pineapple, extra mozzarella",
                        Price = [15.49, 21.99, 26.99, 32.99]
                    },
                    new MenuItem
                    {
                        Name = "Meat Lovers",
                        Description = "Meat Lovers: pepperoni, salami, hamburger, bacon, Italian sausage, mozzarella",
                        Price = [15.49, 21.99, 26.99, 32.99]
                    },
                    new MenuItem
                    {
                        Name = "Cheese Lovers",
                        Description = "Cheese Lovers: mozzarella, feta, cheddar, parmesan",
                        Price = [15.49, 21.99, 26.99, 32.99]
                    },
                    new MenuItem
                    {
                        Name = "Classic BBO Chicken",
                        Description = "Classic BBO Chicken: chicken, BBO sauce, mozzarella",
                        Price = [15.49, 21.99, 26.99, 32.99]
                    },
                    new MenuItem
                    {
                        Name = "BBO Chicken with the Works",
                        Description = "BBO Chicken with the Works: chicken, BBQ sauce, onions, green peppers, tomatoes, mozzarella",
                        Price = [15.49, 21.99, 26.99, 32.99]
                    },
                    new MenuItem
                    {
                        Name = "Chicken Bruschetta",
                        Description = "Chicken Bruschetta: garlic spread, chicken, tomatoes, mozzarella, parsiey, olive oil",
                        Price = [15.49, 21.99, 26.99, 32.99]
                    },

                ]
            };

            return pizza;

        }
    }
}
