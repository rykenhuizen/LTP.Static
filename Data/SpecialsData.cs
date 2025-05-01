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
                    Deal = "29.99"
                },
                new() {
                    Name = "Combo 2",
                    Description =
                    [
                        "16\" Pizza (4 items)",
                        "12\" Garlic Fingers",
                    ],
                    Deal = "32.99"
                },
                new() {
                    Name = "Combo 3",
                    Description =
                    [
                        "16\" Pizza (4 items)",
                        "16\" Garlic Fingers",
                    ],
                    Deal = "36.99"
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
                    Deal = "36.99"
                },
                new() {
                    Name = "Combo 7",
                    Description =
                    [
                        "12\" Pizza (4 items)",
                        "2 Regular Donairs",
                    ],
                    Deal = "34.99"
                },
                new() {
                    Name = "Combo 8",
                    Description =
                    [
                        "2x16\" Pizza (4 items)",
                        "12\" Garlic Fingers",
                    ],
                    Deal = "54.99"
                },

                new() {
                    Name = "Combo 9",
                    Description =
                    [
                        "12\" Pizza",
                        "6 donair Egg Rolls",
                    ],
                    Deal = "29.99"
                },
                new() {
                    Name = "Combo 10",
                    Description =
                    [
                        "16\" Pizza",
                        "6 donair Egg Rolls",
                    ],
                    Deal = "34.99"
                },
                 new() {
                    Name = "Combo 11",
                    Description =
                    [
                        "2 Regular Donairs or",
                        "2 Regular Poutines",
                        "and any 2 Deserts",
                    ],
                    Deal = "32.99"
                },
                 new() {
                    Name = "Combo 12",
                    Description =
                    [
                        "12\" Pepperoni Pizza",
                        "10 Wings",
                        "6 donair Egg Rolls",
                    ],
                    Deal = "36.99"
                },
            ];
        }
    }
}
