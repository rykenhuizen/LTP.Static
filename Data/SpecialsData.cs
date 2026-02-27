using LTP.Static.Models;

namespace LTP.Static.Data
{
    public static class SpecialsData
    {
        public static Special[] GetSpecials()
        {
            return
            [
                new() {
                    Name = "Combo 1",
                    Description =
                    [
                        "12\" Pizza (4 items)",
                        "12\" Garlic Fingers",
                    ],
                    Deal = "30.99"
                },
                new() {
                    Name = "Combo 2",
                    Description =
                    [
                        "16\" Pizza (4 items)",
                        "12\" Garlic Fingers",
                    ],
                    Deal = "33.99"
                },
                new() {
                    Name = "Combo 3",
                    Description =
                    [
                        "16\" Pizza (4 items)",
                        "16\" Garlic Fingers",
                    ],
                    Deal = "37.99"
                },
                new() {
                    Name = "Combo 4",
                    Description =
                    [
                        "2x12\" Pizza",
                    ],
                    Deal = "$4.00 OFF"
                },
                new() {
                    Name = "Combo 5",
                    Description =
                    [
                        "2x16\" Pizza",
                    ],
                    Deal = "$5.00 OFF"
                },
                new() {
                    Name = "Combo 6",
                    Description =
                    [
                        "Any 16\" Pizza",
                        "10 Wings",
                    ],
                    Deal = "37.99"
                },
                new() {
                    Name = "Combo 7",
                    Description =
                    [
                        "12\" Pizza (4 items)",
                        "2 Regular Donairs",
                    ],
                    Deal = "35.99"
                },
                new() {
                    Name = "Combo 8",
                    Description =
                    [
                        "2x16\" Pizza (4 items)",
                        "12\" Garlic Fingers",
                    ],
                    Deal = "56.99"
                },

                new() {
                    Name = "Combo 9",
                    Description =
                    [
                        "12\" Pizza",
                        "6 donair Egg Rolls",
                    ],
                    Deal = "30.99"
                },
                new() {
                    Name = "Combo 10",
                    Description =
                    [
                        "16\" Pizza",
                        "6 donair Egg Rolls",
                    ],
                    Deal = "35.99"
                },
                 new() {
                    Name = "Combo 11",
                    Description =
                    [
                        "2 Regular Donairs or",
                        "2 Regular Poutines",
                        "and any 2 Deserts",
                    ],
                    Deal = "33.99"
                },
                 new() {
                    Name = "Combo 12",
                    Description =
                    [
                        "12\" Pepperoni Pizza",
                        "10 Wings",
                        "6 donair Egg Rolls",
                    ],
                    Deal = "37.99"
                },
            ];
        }
    }
}
