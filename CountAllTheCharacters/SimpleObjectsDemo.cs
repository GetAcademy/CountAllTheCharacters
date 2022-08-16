namespace CountAllTheCharacters
{
    internal class SimpleObjectsDemo
    {
        public static void Run()
        {
            Demo1();
            Demo2();
            Demo3();
        }

        private static void Demo3()
        {
            /*
               let model = {
                    people: [
                      {
                          firstName: 'Terje',
                          birthYear: 1975,
                      },
                      {
                          firstName: 'Per',
                          birthYear: 1980,
                      },
                    ],
                    page: 'home',
                };        
               */

            var model = new Model()
            {
                Page = "home",
                People = new Person[]
                {
                    new Person
                    {
                        FirstName = "Terje",
                        BirthYear = 1975,
                    },
                    new Person
                    {
                        FirstName = "Per",
                        BirthYear = 1980,
                    }
                }
            };

            var model2 = new Model();
            model2.Page = "home";
            model2.People = new Person[2];
            model2.People[0] = new Person();
            model2.People[0].FirstName = "Terje";
            model2.People[0].BirthYear= 1975;
            model2.People[1] = new Person();
            model2.People[1].FirstName = "Per";
            model2.People[1].BirthYear= 1980;

            var people = model2.People;
            foreach (var person in people)
            {
                
            }
        }

        private static void Demo2()
        {
            /*
             let people = [
                {
                    firstName: 'Terje',
                    birthYear: 1975,
                },
                {
                    firstName: 'Per',
                    birthYear: 1980,
                },
            ];

            let people2 = [];
            people2[0} = {
                    firstName: 'Terje',
                    birthYear: 1975,
                };
            people2[1] = {
                    firstName: 'Per',
                    birthYear: 1980,
                };
             */

            var people = new Person[]
            {
                new Person
                {
                    FirstName = "Terje",
                    BirthYear = 1975,
                },
                new Person
                {
                    FirstName = "Per",
                    BirthYear = 1980,
                }
            };


            var people2 = new Person[2];
            people2[0] = new Person
            {
                FirstName = "Terje",
                BirthYear = 1975,
            };
            people2[1] = new Person
            {
                FirstName = "Per",
                BirthYear = 1980,
            };


        }

        private static void Demo1()
        {
            /*
             let terje = {
                firstName: 'Terje',
                birthYear: 1975,
             };

             let terje2 = {};
             terje2.firstName = 'Terje;
             terje2.birthYear = 1975;
             */

            var terje = new Person
            {
                FirstName = "Terje",
                BirthYear = 1975,
            };

            var terje2 = new Person();
            terje2.FirstName = "Terje";
            terje2.BirthYear = 1975;
        }
    }
}
