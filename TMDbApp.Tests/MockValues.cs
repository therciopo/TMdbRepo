﻿using Newtonsoft.Json;
using TMDbApp.Services.DTO;

namespace UnitTestProject1
{
    public class MockValues
    {
        public static MoviesResult GetUpcomingMovies()
        {
            string movies = "{\n  \"page\": 1,\n  \"results\": [\n    {\n      \"poster_path\": \"/rXMWOZiCt6eMX22jWuTOSdQ98bY.jpg\",\n      \"adult\": false,\n      \"overview\": \"Though Kevin has evidenced 23 personalities to his trusted psychiatrist, Dr. Fletcher, there remains one still submerged who is set to materialize and dominate all the others. Compelled to abduct three teenage girls led by the willful, observant Casey, Kevin reaches a war for survival among all of those contained within him — as well as everyone around him — as the walls between his compartments shatter apart.\",\n      \"release_date\": \"2017-01-19\",\n      \"genre_ids\": [\n        27,\n        53\n      ],\n      \"id\": 381288,\n      \"original_title\": \"Split\",\n      \"original_language\": \"en\",\n      \"title\": \"Split\",\n      \"backdrop_path\": \"/4G6FNNLSIVrwSRZyFs91hQ3lZtD.jpg\",\n      \"popularity\": 43.445081,\n      \"vote_count\": 1869,\n      \"video\": false,\n      \"vote_average\": 6.8\n    },\n    {\n      \"poster_path\": \"/iRAZIEgfB9N0BObV0QI61Nxh92h.jpg\",\n      \"adult\": false,\n      \"overview\": \"Saban's Power Rangers follows five ordinary teens who must become something extraordinary when they learn that their small town of Angel Grove — and the world — is on the verge of being obliterated by an alien threat. Chosen by destiny, our heroes quickly discover they are the only ones who can save the planet. But to do so, they will have to overcome their real-life issues and before it’s too late, band together as the Power Rangers.\",\n      \"release_date\": \"2017-03-23\",\n      \"genre_ids\": [\n        28,\n        12,\n        878\n      ],\n      \"id\": 305470,\n      \"original_title\": \"Power Rangers\",\n      \"original_language\": \"en\",\n      \"title\": \"Power Rangers\",\n      \"backdrop_path\": \"/eQkaPwMpJARFoPvbbNz2Z0Kye4O.jpg\",\n      \"popularity\": 13.204315,\n      \"vote_count\": 278,\n      \"video\": false,\n      \"vote_average\": 6.5\n    },\n    {\n      \"poster_path\": \"/6cbIDZLfwUTmttXTmNi8Mp3Rnmg.jpg\",\n      \"adult\": false,\n      \"overview\": \"The untold story of Katherine G. Johnson, Dorothy Vaughan and Mary Jackson – brilliant African-American women working at NASA and serving as the brains behind one of the greatest operations in history – the launch of astronaut John Glenn into orbit. The visionary trio crossed all gender and race lines to inspire generations to dream big.\",\n      \"release_date\": \"2016-12-10\",\n      \"genre_ids\": [\n        36,\n        18\n      ],\n      \"id\": 381284,\n      \"original_title\": \"Hidden Figures\",\n      \"original_language\": \"en\",\n      \"title\": \"Hidden Figures\",\n      \"backdrop_path\": \"/vifqDyPOB6jd5vwP2SIqWNtXUHu.jpg\",\n      \"popularity\": 12.744813,\n      \"vote_count\": 1101,\n      \"video\": false,\n      \"vote_average\": 7.7\n    },\n    {\n      \"poster_path\": \"/1SwAVYpuLj8KsHxllTF8Dt9dSSX.jpg\",\n      \"adult\": false,\n      \"overview\": \"A young black man visits his white girlfriend's cursed family estate. He finds out that many of its residents, who are black, have gone missing in the past.\",\n      \"release_date\": \"2017-02-24\",\n      \"genre_ids\": [\n        53\n      ],\n      \"id\": 419430,\n      \"original_title\": \"Get Out\",\n      \"original_language\": \"en\",\n      \"title\": \"Get Out\",\n      \"backdrop_path\": \"/Ae58bf7Yj6OPzwKerPgXSnxCJdh.jpg\",\n      \"popularity\": 8.588792,\n      \"vote_count\": 525,\n      \"video\": false,\n      \"vote_average\": 7.1\n    },\n    {\n      \"poster_path\": \"/cEPR5dx1XMMvBtuzBIL4rR5xnh5.jpg\",\n      \"adult\": false,\n      \"overview\": \"Father and son coroners who receive a mysterious homicide victim with no apparent cause of death. As they attempt to identify the beautiful young \\\"Jane Doe,\\\" they discover increasingly bizarre clues that hold the key to her terrifying secrets.\",\n      \"release_date\": \"2016-12-21\",\n      \"genre_ids\": [\n        27,\n        9648\n      ],\n      \"id\": 397243,\n      \"original_title\": \"The Autopsy of Jane Doe\",\n      \"original_language\": \"en\",\n      \"title\": \"The Autopsy of Jane Doe\",\n      \"backdrop_path\": \"/m4LtS8NoVvbl57mej9KBg9QT4fg.jpg\",\n      \"popularity\": 8.412456,\n      \"vote_count\": 301,\n      \"video\": false,\n      \"vote_average\": 6.5\n    },\n    {\n      \"poster_path\": \"/gaHepzSTMkGwsSKAqiBgroSCf07.jpg\",\n      \"adult\": false,\n      \"overview\": \"The Guardians must fight to keep their newfound family together as they unravel the mysteries of Peter Quill's true parentage.\",\n      \"release_date\": \"2017-04-25\",\n      \"genre_ids\": [\n        28,\n        12,\n        878\n      ],\n      \"id\": 283995,\n      \"original_title\": \"Guardians of the Galaxy Vol. 2\",\n      \"original_language\": \"en\",\n      \"title\": \"Guardians of the Galaxy Vol. 2\",\n      \"backdrop_path\": \"/8sFWWIolWPm2FQLNt9cSKpNZJcz.jpg\",\n      \"popularity\": 8.099629,\n      \"vote_count\": 10,\n      \"video\": false,\n      \"vote_average\": 6.3\n    },\n    {\n      \"poster_path\": \"/9WkUSY33MDPGmz0vtzbsfaxTHVa.jpg\",\n      \"adult\": false,\n      \"overview\": \"Undercover Las Vegas police officer Vincent Downs is caught in a high stakes web of corrupt cops and the mob-controlled casino underground. When a heist goes wrong, a crew of homicidal gangsters kidnaps Downs’ teenage son. In one sleepless night he will have to rescue his son, evade an internal affairs investigation and bring the kidnappers to justice.\",\n      \"release_date\": \"2017-01-12\",\n      \"genre_ids\": [\n        28,\n        80,\n        53\n      ],\n      \"id\": 324542,\n      \"original_title\": \"Sleepless\",\n      \"original_language\": \"en\",\n      \"title\": \"Sleepless\",\n      \"backdrop_path\": \"/9VEOQvCnd8T8wILgyqjKgyhALw4.jpg\",\n      \"popularity\": 7.774158,\n      \"vote_count\": 117,\n      \"video\": false,\n      \"vote_average\": 5.9\n    },\n    {\n      \"poster_path\": \"/cDbEiJIRwFcx2GsClJ1hDUY5Vwj.jpg\",\n      \"adult\": false,\n      \"overview\": \"An account of Boston Police Commissioner Ed Davis's actions in the events leading up to the 2013 Boston Marathon bombing and the aftermath, which includes the city-wide manhunt to find the terrorists behind it.\",\n      \"release_date\": \"2016-12-12\",\n      \"genre_ids\": [\n        18,\n        36,\n        53\n      ],\n      \"id\": 388399,\n      \"original_title\": \"Patriots Day\",\n      \"original_language\": \"en\",\n      \"title\": \"Patriots Day\",\n      \"backdrop_path\": \"/tiBL4PeaCPKGBz3qO4dJP2KzKop.jpg\",\n      \"popularity\": 7.543702,\n      \"vote_count\": 303,\n      \"video\": false,\n      \"vote_average\": 6.6\n    },\n    {\n      \"poster_path\": \"/ewVHnq4lUiovxBCu64qxq5bT2lu.jpg\",\n      \"adult\": false,\n      \"overview\": \"Bound for a remote planet on the far side of the galaxy, the crew of the colony ship Covenant discovers what they think is an uncharted paradise, but is actually a dark, dangerous world — whose sole inhabitant is the “synthetic” David, survivor of the doomed Prometheus expedition.\",\n      \"release_date\": \"2017-05-10\",\n      \"genre_ids\": [\n        12,\n        28,\n        27,\n        878,\n        53\n      ],\n      \"id\": 126889,\n      \"original_title\": \"Alien: Covenant\",\n      \"original_language\": \"en\",\n      \"title\": \"Alien: Covenant\",\n      \"backdrop_path\": \"/kMU8trT43p5LFoJ4plIySMOsZ1T.jpg\",\n      \"popularity\": 6.266914,\n      \"vote_count\": 0,\n      \"video\": false,\n      \"vote_average\": 0\n    },\n    {\n      \"poster_path\": \"/25oWTCGqIik4gUTMidx3L8DI4Bt.jpg\",\n      \"adult\": false,\n      \"overview\": \"Based on the airline accident that occurred in July of 2002 and on the events that took place 478 days later.\",\n      \"release_date\": \"2017-04-06\",\n      \"genre_ids\": [\n        18,\n        53\n      ],\n      \"id\": 390051,\n      \"original_title\": \"Aftermath\",\n      \"original_language\": \"en\",\n      \"title\": \"Aftermath\",\n      \"backdrop_path\": \"/9HcXzYUnnwyFu9WSEM2IOxd2VhC.jpg\",\n      \"popularity\": 5.621554,\n      \"vote_count\": 24,\n      \"video\": false,\n      \"vote_average\": 5.7\n    },\n    {\n      \"poster_path\": \"/m5HSTW3YTOu4b0TZUA6cbroOl2J.jpg\",\n      \"adult\": false,\n      \"overview\": \"When three college students move into an old house off campus, they unwittingly unleash a supernatural entity known as The Bye Bye Man, who comes to prey upon them once they discover his name. The friends must try to save each other, all the while keeping The Bye Bye Man's existence a secret to save others from the same deadly fate.\",\n      \"release_date\": \"2017-01-12\",\n      \"genre_ids\": [\n        27,\n        53\n      ],\n      \"id\": 292280,\n      \"original_title\": \"The Bye Bye Man\",\n      \"original_language\": \"en\",\n      \"title\": \"The Bye Bye Man\",\n      \"backdrop_path\": \"/vg5vePfFVRuNIl1LBSf99YbrxJ4.jpg\",\n      \"popularity\": 4.98812,\n      \"vote_count\": 64,\n      \"video\": false,\n      \"vote_average\": 5.4\n    },\n    {\n      \"poster_path\": \"/vdHUj9cyRe7fIYdJFMyc7elnawC.jpg\",\n      \"adult\": false,\n      \"overview\": \"A boy attempts to deal with his mother's illness and the bullying of his classmates by escaping to a fantastical world.\",\n      \"release_date\": \"2016-10-07\",\n      \"genre_ids\": [\n        18,\n        14\n      ],\n      \"id\": 258230,\n      \"original_title\": \"A Monster Calls\",\n      \"original_language\": \"en\",\n      \"title\": \"A Monster Calls\",\n      \"backdrop_path\": \"/xVW8REyVqKwxAtUYY07UGlZH43L.jpg\",\n      \"popularity\": 4.916225,\n      \"vote_count\": 479,\n      \"video\": false,\n      \"vote_average\": 6.5\n    },\n    {\n      \"poster_path\": \"/ik3ebv7J18fs6cHkmu91oxz7EGt.jpg\",\n      \"adult\": false,\n      \"overview\": \"A true-life drama, centering on British explorer Col. Percival Fawcett, who disappeared while searching for a mysterious city in the Amazon in the 1920s.\",\n      \"release_date\": \"2017-03-15\",\n      \"genre_ids\": [\n        28,\n        12\n      ],\n      \"id\": 314095,\n      \"original_title\": \"The Lost City of Z\",\n      \"original_language\": \"en\",\n      \"title\": \"The Lost City of Z\",\n      \"backdrop_path\": \"/dAQzSsITJVxyk9ChqPLyBEwtGuC.jpg\",\n      \"popularity\": 4.525968,\n      \"vote_count\": 61,\n      \"video\": false,\n      \"vote_average\": 5.9\n    },\n    {\n      \"poster_path\": \"/4nfWsdsJfO5srRZgxiWC9xHub0W.jpg\",\n      \"adult\": false,\n      \"overview\": \"Desperate to pay the bills and come through for their loved ones, three lifelong pals risk it all by embarking on a daring bid to knock off the very bank that absconded with their money.\",\n      \"release_date\": \"2017-04-06\",\n      \"genre_ids\": [\n        35\n      ],\n      \"id\": 353070,\n      \"original_title\": \"Going in Style\",\n      \"original_language\": \"en\",\n      \"title\": \"Going in Style\",\n      \"backdrop_path\": \"/uARnuPezr7eZkOsHj2ujFQz6EKE.jpg\",\n      \"popularity\": 4.232583,\n      \"vote_count\": 25,\n      \"video\": false,\n      \"vote_average\": 5.9\n    },\n    {\n      \"poster_path\": \"/pZ2qeZeX9qkfVtpHj3LzSkskpAS.jpg\",\n      \"adult\": false,\n      \"overview\": \"A woman discovers that severe catastrophic events are somehow connected to the mental breakdown from which she's suffering.\",\n      \"release_date\": \"2017-02-23\",\n      \"genre_ids\": [\n        35,\n        878,\n        28\n      ],\n      \"id\": 339967,\n      \"original_title\": \"Colossal\",\n      \"original_language\": \"en\",\n      \"title\": \"Colossal\",\n      \"backdrop_path\": \"/jcCVu9A4SOn9Y3ZI3pbYNSaUSlP.jpg\",\n      \"popularity\": 3.609177,\n      \"vote_count\": 17,\n      \"video\": false,\n      \"vote_average\": 7.6\n    },\n    {\n      \"poster_path\": \"/byeTgTgG7M1RN2c7njWWIkSkNig.jpg\",\n      \"adult\": false,\n      \"overview\": \"An ambitious young executive is sent to retrieve his company's CEO from an idyllic but mysterious \\\"wellness center\\\" at a remote location in the Swiss Alps but soon suspects that the spa's miraculous treatments are not what they seem.\",\n      \"release_date\": \"2017-02-15\",\n      \"genre_ids\": [\n        18,\n        27,\n        9648,\n        53\n      ],\n      \"id\": 340837,\n      \"original_title\": \"A Cure for Wellness\",\n      \"original_language\": \"en\",\n      \"title\": \"A Cure for Wellness\",\n      \"backdrop_path\": \"/6oXUTHVAjPrNKvVFZhxNlWv7jua.jpg\",\n      \"popularity\": 3.526172,\n      \"vote_count\": 223,\n      \"video\": false,\n      \"vote_average\": 5.5\n    },\n    {\n      \"poster_path\": \"/zSVRoZMce3skt6qR6JSD0IXQ8af.jpg\",\n      \"adult\": false,\n      \"overview\": \"A crime drama set in 1970s Boston, about a gun sale which goes wrong.\",\n      \"release_date\": \"2017-03-31\",\n      \"genre_ids\": [\n        28,\n        35,\n        80\n      ],\n      \"id\": 334521,\n      \"original_title\": \"Free Fire\",\n      \"original_language\": \"en\",\n      \"title\": \"Free Fire\",\n      \"backdrop_path\": \"/lPdhR8njOQWT3US0vmpQXVoOHFC.jpg\",\n      \"popularity\": 3.498331,\n      \"vote_count\": 27,\n      \"video\": false,\n      \"vote_average\": 6\n    },\n    {\n      \"poster_path\": \"/v2s7UnfpDRJWd52YrDeK3Xs3hIL.jpg\",\n      \"adult\": false,\n      \"overview\": \"An unexpected affair quickly escalates into a heart-stopping reality for two women whose passionate connection changes their lives forever.\",\n      \"release_date\": \"2017-02-10\",\n      \"genre_ids\": [\n        18,\n        10749\n      ],\n      \"id\": 370663,\n      \"original_title\": \"Below Her Mouth\",\n      \"original_language\": \"en\",\n      \"title\": \"Below Her Mouth\",\n      \"backdrop_path\": \"/okSVtwaS8DqLHGe1QQgREf2haCy.jpg\",\n      \"popularity\": 3.417313,\n      \"vote_count\": 37,\n      \"video\": false,\n      \"vote_average\": 6.3\n    },\n    {\n      \"poster_path\": \"/wBwbV2NrnHtTNsjC0RASAyE53P0.jpg\",\n      \"adult\": false,\n      \"overview\": \"A woman sets out to make life hell for her ex-husband's new wife.\",\n      \"release_date\": \"2017-04-20\",\n      \"genre_ids\": [\n        53\n      ],\n      \"id\": 418437,\n      \"original_title\": \"Unforgettable\",\n      \"original_language\": \"en\",\n      \"title\": \"Unforgettable\",\n      \"backdrop_path\": \"/hrxNhJR5C4i9PdL5mNGxtAD9IYI.jpg\",\n      \"popularity\": 3.392057,\n      \"vote_count\": 0,\n      \"video\": false,\n      \"vote_average\": 0\n    },\n    {\n      \"poster_path\": \"/lCdgGqZ0ibzmtUoqdgGOcXAoA59.jpg\",\n      \"adult\": false,\n      \"overview\": \"It's Hollywood, 1958. Small town beauty queen and devout Baptist virgin Marla Mabrey, under contract to the infamous Howard Hughes, arrives in Los Angeles. At the airport, she meets her driver Frank Forbes, who is engaged to be married to his seventh grade sweetheart and is a deeply religious Methodist. Their instant attraction not only puts their religious convictions to the test, but also defies Hughes' number one rule: No employee is allowed to have any relationship whatsoever with a contract actress. Hughes' behavior intersects with Marla and Frank in very separate and unexpected ways, and as they are drawn deeper into his bizarre world, their values are challenged and their lives are changed.\",\n      \"release_date\": \"2016-11-23\",\n      \"genre_ids\": [\n        35,\n        18,\n        10749\n      ],\n      \"id\": 291328,\n      \"original_title\": \"Rules Don't Apply\",\n      \"original_language\": \"en\",\n      \"title\": \"Rules Don't Apply\",\n      \"backdrop_path\": \"/xA959uQHOMCV1as2ZbUfm06dyXw.jpg\",\n      \"popularity\": 2.937209,\n      \"vote_count\": 39,\n      \"video\": false,\n      \"vote_average\": 6\n    }\n  ],\n  \"dates\": {\n    \"maximum\": \"2017-05-17\",\n    \"minimum\": \"2017-04-26\"\n  },\n  \"total_pages\": 11,\n  \"total_results\": 214\n}";
            return JsonConvert.DeserializeObject<MoviesResult>(movies);
        }
        public static MoviesResult GetSearchMovies()
        {
            string movies = "{\n  \"page\": 1,\n  \"results\": [\n    {\n      \"poster_path\": \"/38bmEXmuJuInLs9dwfgOGCHmZ7l.jpg\",\n      \"adult\": false,\n      \"overview\": \"In an innocent heartland city, five are shot dead by an expert sniper. The police quickly identify and arrest the culprit, and build a slam-dunk case. But the accused man claims he's innocent and says \\\"Get Jack Reacher.\\\" Reacher himself sees the news report and turns up in the city. The defense is immensely relieved, but Reacher has come to bury the guy. Shocked at the accused's request, Reacher sets out to confirm for himself the absolute certainty of the man's guilt, but comes up with more than he bargained for.\",\n      \"release_date\": \"2012-12-20\",\n      \"genre_ids\": [\n        80,\n        18,\n        53\n      ],\n      \"id\": 75780,\n      \"original_title\": \"Jack Reacher\",\n      \"original_language\": \"en\",\n      \"title\": \"Jack Reacher\",\n      \"backdrop_path\": \"/ezXodpP429qK0Av89pVNlaXWJkQ.jpg\",\n      \"popularity\": 5.212934,\n      \"vote_count\": 2620,\n      \"video\": false,\n      \"vote_average\": 6.3\n    },\n    {\n      \"poster_path\": \"/IfB9hy4JH1eH6HEfIgIGORXi5h.jpg\",\n      \"adult\": false,\n      \"overview\": \"Jack Reacher must uncover the truth behind a major government conspiracy in order to clear his name. On the run as a fugitive from the law, Reacher uncovers a potential secret from his past that could change his life forever.\",\n      \"release_date\": \"2016-10-19\",\n      \"genre_ids\": [\n        28,\n        80,\n        18,\n        9648,\n        53\n      ],\n      \"id\": 343611,\n      \"original_title\": \"Jack Reacher: Never Go Back\",\n      \"original_language\": \"en\",\n      \"title\": \"Jack Reacher: Never Go Back\",\n      \"backdrop_path\": \"/nDS8rddEK74HfAwCC5CoT6Cwzlt.jpg\",\n      \"popularity\": 7.785596,\n      \"vote_count\": 1418,\n      \"video\": false,\n      \"vote_average\": 5.1\n    }\n  ],\n  \"total_results\": 2,\n  \"total_pages\": 1\n}";
            return JsonConvert.DeserializeObject<MoviesResult>(movies);
        }
        public static GenreResult GetGenres()
        {
            string genres = "{\n  \"genres\": [\n    {\n      \"id\": 28,\n      \"name\": \"Action\"\n    },\n    {\n      \"id\": 12,\n      \"name\": \"Adventure\"\n    },\n    {\n      \"id\": 16,\n      \"name\": \"Animation\"\n    },\n    {\n      \"id\": 35,\n      \"name\": \"Comedy\"\n    },\n    {\n      \"id\": 80,\n      \"name\": \"Crime\"\n    },\n    {\n      \"id\": 99,\n      \"name\": \"Documentary\"\n    },\n    {\n      \"id\": 18,\n      \"name\": \"Drama\"\n    },\n    {\n      \"id\": 10751,\n      \"name\": \"Family\"\n    },\n    {\n      \"id\": 14,\n      \"name\": \"Fantasy\"\n    },\n    {\n      \"id\": 36,\n      \"name\": \"History\"\n    },\n    {\n      \"id\": 27,\n      \"name\": \"Horror\"\n    },\n    {\n      \"id\": 10402,\n      \"name\": \"Music\"\n    },\n    {\n      \"id\": 9648,\n      \"name\": \"Mystery\"\n    },\n    {\n      \"id\": 10749,\n      \"name\": \"Romance\"\n    },\n    {\n      \"id\": 878,\n      \"name\": \"Science Fiction\"\n    },\n    {\n      \"id\": 10770,\n      \"name\": \"TV Movie\"\n    },\n    {\n      \"id\": 53,\n      \"name\": \"Thriller\"\n    },\n    {\n      \"id\": 10752,\n      \"name\": \"War\"\n    },\n    {\n      \"id\": 37,\n      \"name\": \"Western\"\n    }\n  ]\n}";
            return JsonConvert.DeserializeObject<GenreResult>(genres);
        }
    }
}
