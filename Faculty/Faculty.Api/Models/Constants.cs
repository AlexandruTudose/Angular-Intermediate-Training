namespace Faculty.Api.Models;

public static class Constants
{
    public static readonly IReadOnlyList<string> FirstNames = new List<string>
    {
        "Aaron", "Abigail", "Adam", "Alan", "Albert", "Alexander", "Alexis", "Alice", "Amanda", "Amber", "Amy",
        "Andrea", "Andrew", "Angela", "Ann", "Anna", "Anthony", "Arthur", "Ashley", "Austin", "Barbara", "Benjamin",
        "Betty", "Beverly", "Billy", "Bobby", "Brandon", "Brenda", "Brian", "Brittany", "Bruce", "Bryan", "Carl",
        "Carol", "Carolyn", "Catherine", "Charles", "Charlotte", "Cheryl", "Christian", "Christina", "Christine",
        "Christopher", "Cynthia", "Daniel", "Danielle", "David", "Deborah", "Debra", "Denise", "Dennis", "Diana",
        "Diane", "Donald", "Donna", "Doris", "Dorothy", "Douglas", "Dylan", "Edward", "Elijah", "Elizabeth", "Emily",
        "Emma", "Eric", "Ethan", "Eugene", "Evelyn", "Frances", "Frank", "Gabriel", "Gary", "George", "Gerald",
        "Gloria", "Grace", "Gregory", "Hannah", "Harold", "Heather", "Helen", "Henry", "Isabella", "Jack", "Jacob",
        "Jacqueline", "James", "Janet", "Janice", "Jason", "Jean", "Jeffrey", "Jennifer", "Jeremy", "Jerry", "Jesse",
        "Jessica", "Joan", "Joe", "John", "Jonathan", "Jordan", "Jose", "Joseph", "Joshua", "Joyce", "Juan", "Judith",
        "Judy", "Julia", "Julie", "Justin", "Karen", "Katherine", "Kathleen", "Kathryn", "Kayla", "Keith", "Kelly",
        "Kenneth", "Kevin", "Kimberly", "Kyle", "Larry", "Laura", "Lauren", "Lawrence", "Linda", "Lisa", "Logan",
        "Lori", "Louis", "Madison", "Margaret", "Maria", "Marie", "Marilyn", "Mark", "Martha", "Mary", "Mason",
        "Matthew", "Megan", "Melissa", "Michael", "Michelle", "Nancy", "Natalie", "Nathan", "Nicholas", "Nicole",
        "Noah", "Olivia", "Pamela", "Patricia", "Patrick", "Paul", "Peter", "Philip", "Rachel", "Ralph", "Randy",
        "Raymond", "Rebecca", "Richard", "Robert", "Roger", "Ronald", "Roy", "Russell", "Ruth", "Ryan", "Samantha",
        "Samuel", "Sandra", "Sara", "Sarah", "Scott", "Sean", "Sharon", "Shirley", "Sophia", "Stephanie", "Stephen",
        "Steven", "Susan", "Teresa", "Terry", "Theresa", "Thomas", "Timothy", "Tyler", "Victoria", "Vincent",
        "Virginia", "Walter", "Wayne", "William", "Willie", "Zachary"
    };

    public static readonly IReadOnlyList<string> LastNames = new List<string>
    {
        "SMITH", "JONES", "WILLIAMS", "TAYLOR", "BROWN", "DAVIES", "EVANS", "WILSON", "THOMAS", "JOHNSON", "ROBERTS",
        "ROBINSON", "THOMPSON", "WRIGHT", "WALKER", "WHITE", "EDWARDS", "HUGHES", "GREEN", "HALL", "LEWIS", "HARRIS",
        "CLARKE", "PATEL", "LEE", "JACKSON", "WOOD", "TURNER", "MARTIN", "COOPER", "HILL", "WARD", "MORRIS", "MOORE",
        "CLARK", "KING", "BAKER", "HARRISON", "MORGAN", "ALLEN", "JAMES", "SCOTT", "PHILLIPS", "WATSON", "DAVIS",
        "PARKER", "PRICE", "BENNETT", "YOUNG", "GRIFFITHS"
    };

    public static readonly IReadOnlyList<string> CourseNames = new List<string>
    {
        "Algorithms", "Angular", "Bioinformatics", "Compilers and language theory", "Computer architecture",
        "Computer engineering", "Cryptography", "Data structures", "Databases", "Databases", "Dynamic programming",
        "Graphic design with computers", "Information security", "Information theory", "Introduction to Programming",
        "Java", "JavaScript", "Networking", "Object-oriented programming", "Programming Languages",
        "Scientific computing", "Server administration", "Shell Scripting", "Software project management",
        "Software testing", "Theory of programming languages", "TypeScript"
    };

    public static readonly IReadOnlyList<int> Year = new List<int> { 1, 2, 3, 4 };
    
    public static readonly IReadOnlyList<int> Credits = new List<int> { 3, 4, 5, 6, 7 };

    public static readonly IReadOnlyList<int> Grades = new List<int>
    {
        5, 5, 5, 6, 6, 7, 7, 7, 7, 7, 8, 8, 8, 9, 9, 9, 9, 10
    };

    public static readonly IReadOnlyList<string> Group = new List<string>
    {
        "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9"
    };

    public static readonly IReadOnlyList<int> Scholarship = new List<int>
    {
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 100, 100, 100, 250, 250, 500
    };

    public const string AlphanumericChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    public const int ReferenceYear = 1998;
}