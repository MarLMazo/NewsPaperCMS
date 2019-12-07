-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: Dec 07, 2019 at 01:40 AM
-- Server version: 5.7.24
-- PHP Version: 7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `newspaper`
--

-- --------------------------------------------------------

--
-- Table structure for table `news`
--

CREATE TABLE `news` (
  `NEWSID` int(20) UNSIGNED NOT NULL,
  `NEWSTITLE` varchar(255) COLLATE latin1_bin NOT NULL,
  `NEWSCONTENT` mediumtext COLLATE latin1_bin NOT NULL,
  `NEWSDATE` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_bin;

--
-- Dumping data for table `news`
--

INSERT INTO `news` (`NEWSID`, `NEWSTITLE`, `NEWSCONTENT`, `NEWSDATE`) VALUES
(1, 'Raptors Boucher, Brissett, plan to play for Canada in Olympic qualifying tournament', 'TORONTO - Centre Chris Boucher and forward Oshae Brissett of the Toronto Raptors have said they intend to play for Canada at an Olympic men\'s basketball qualifying tournament next year in Victoria.\r\n\r\nMontreal\'s Boucher has seen increased minutes with the Raptors due to an injury to bench leader Serge Ibaka. The former MVP of the developmental G League is averaging 6.2 points, 5.1 rebounds and 13.5 minutes per game. He has posted a double-double in three of his last five games.\r\n\r\n“To shut down all the rumours, I (would) love to play for team Canada this summer,” Boucher posted on Twitter.\r\n\r\nPHOTOS\r\nOshae Brissett\r\nSyracuse\'s Oshae Brissett brings the ball up court during practice at the NCAA men\'s college basketball tournament Wednesday, March 20, 2019, in Salt Lake City. (AP Photo/Rick Bowmer)\r\n\r\nBrissett, from Mississauga, Ont., signed a two-way contract with Toronto before the season after going undrafted following two years at Syracuse. He is averaging one point, 0.3 rebounds, 0.3 assists and 4.3 minutes per game.\r\n\r\nHe\'s averaging 15.3 points, 7.5 rebounds, 2.3 assists and 32.3 minutes with Raptors 905 of the G League.\r\n\r\n“I always take pride in playing for my country and look to put my efforts into helping â†•CanBball,” he posted on Twitter. “Injury sidelined me last summer but I look forward to helping my guys this summer. Let\'s go Canada.”\r\n\r\nDenver guard Jamal Murray, Oklahoma City guard Shai Gilgeous-Alexander, New Orleans guard and Nickeil Alexander-Walker, Memphis swingman Dillon Brooks, Dallas centre Dwight Powell and Orlando big man Khem Birch have also said they plan to play for Canada at the tournament, which runs June 23-28.\r\n\r\nCanada will host Greece, the Czech Republic, Turkey, China and Uruguay in the last-chance qualifying tournament. Canada must win to clinch its first men\'s Olympic berth since the 2000 Sydney Games.', '2019-11-29'),
(2, '2 K-pop stars get prison terms for sexual crimes', 'SEOUL, Korea, Republic Of - A South Korean court on Friday found two K-pop stars guilty of illicit sexual relations with a woman who was unable to resist and sentenced them to up to six years in prison.\r\n\r\nThe Seoul Central District Court said singer-songwriter Jung Joon-young received a six-year prison term and former boy band member Choi Jong-hoon a five-year term.\r\n\r\nThe court said in a statement that they were convicted of committing “special quasi-raping,” which it said means multiple people collaborating to have illicit sextual intercourse with a person who was unconscious or unable to resist.\r\n\r\nJung was additionally convicted of filming sex videos of women against their will and sharing them with friends in a group chat.\r\n\r\nThe two men were also ordered to undergo 80 hours of sex offender treatment programs.\r\n\r\nThey have one week to appeal, according to the court.\r\n\r\nTheir scandals roiled South Korea\'s entertainment industry earlier this year when the investigation began.\r\n\r\nSouth Korean pop songs, TV dramas and films are hugely popular in Asia and beyond, but the country\'s entertainment world has in recent years suffered a series of sexual scandals that revealed its dark side.\r\n\r\nMale stars have faced allegations of sexual assault and abuse and reports have been made that female entertainers and trainees have been forced to provide sexual services to men in power.\r\n\r\nOn Sunday, K-pop musician and actress Goo Hara was found dead at her home in Seoul. Before her death, she suffered cyberbullying after she was engaged in a public dispute with her former boyfriend, who she said threatened to disclose a sex video of her.\r\n\r\nLast month, another K-pop star, Sulli, was discovered dead at her home. She had spoken against the online backlash she received over her lifestyle.\r\n\r\n', '2019-10-20'),
(3, 'Toy sales expected to decrease two per cent in 2019, says industry analyst', 'TORONTO - On the eve of the start of the U.S. holiday shopping season, the prospect for 2019 toy sales has worsened following a slow start to the fourth quarter, an industry analyst said Wednesday.\r\n\r\nBMO analyst Gerrick Johnson says full-year U.S. toy retail sales are expected to decrease by two per cent from 2018, compared with his prior forecast of them being flat.\r\n\r\nThe industry is down 5.5 per cent through the first nine months of the year, a bigger decline than BMO anticipated.\r\n\r\nSales compared to a year ago when retailers offered aggressive promotions in their fight for the 15 per cent of the market that was up for grabs with the closure of Toys R Us stores in the United States.\r\n\r\nWith more inventory at stores and in warehouses, as well as a shift to online shopping, store sales need to increase sharply to avoid liquidations at the end of the quarter that would reduce margins, he said.\r\n\r\nMeanwhile, Pop Pops Snotz from Yulu, L.O.L. Surprise! O.M.G. Dolls from MGA Entertainment, and Blume dolls from Skyrocket headed Johnson\'s top 10 toy list for the holiday season.\r\n\r\nJuno My Baby Elephant from Canada\'s Spin Master ranked fourth.\r\n\r\nThe rest of the list includes X-Power Dozer from Jakks Pacific, Pinkfong Baby Shark Official Song Puppet from WowWee, Hot Wheels Mario Kart die-cast vehicles and track sets from Mattel, The Heroes of Goo Jit Zu from Moose Toys, Buttheads figures from WowWee and Princess dolls inspired by Disney\'s “Ralph Breaks the Internet” from Hasbro.', '2019-10-30'),
(4, 'Wasaga Beach is getting a casino', 'Wasaga Beach\'s much-anticipated new casino project is officially moving forward, as municipal paperwork has finally been completed and approved, and further details of the project have been revealed.\r\n\r\nConstruction on the 10,000-square-metre complex from Gateway Casinos & Entertainment Ltd. will begin in spring 2020, and finish in fall 2021.\r\n\r\nIt is slated to take up an empty 7.5-acre lot in the township\'s west end, at 88 Lyons Court, just south of its Beachwood Road and Mosley Street roundabout.\r\n\r\nThis location is notably not on the town\'s beachfront, which is arguably its main attraction, but was selected after a lengthy and expensive study and deliberation process between Gateway and local government.\r\n\r\nThe entertainment complex will have 300 slots, 10 table games, and two restaurants. Full plans and specifics will be shared with the public sometime next year.', '2019-11-01'),
(5, 'This is what replacing Wayne Gretzky restaurant in Toronto', 'News that Wayne Gretzky\'s restaurant and The Second City would be forced out of their current home at 99 Blue Jays Way was announced last summer, and now we know what\'s likely to replace the two iconic establishments. \r\n\r\nWhile it was already made clear that a condo tower would eventually be built in the old building\'s place, a new proposal for a 47-storey building has been submitted to the city by developer CentreCourt for Site Plan Approval. \r\n\r\nThe proposal includes details for a 155.5 metre-high tower, designed by IBI Group, that matches the warehouse-style of many surrounding buildings that predated the area\'s condo boom, according to Urban Toronto.', '2020-06-28'),
(6, 'Toronto looks like a giant snowglobe right now', 'Oh, the weather outside is frightful... but sure is nice to look at from inside a heated building.\r\n\r\nA fast-moving but fierce winter storm system has descended upon the City of Toronto, where as much as 10 cm of snow is expected to drop by Friday afternoon.\r\n\r\nIt\'s brutal out there for drivers, as Environment Canada forewarned. Motorists are being advised to allow extra time for their morning commutes and to look out for slippery roads as snow accumulates on untreated surfaces.\r\n\r\nFor those who are safe and sound indoors, things are a lot cozier — and prettier to look at through the window.', '2019-03-09'),
(7, '10 Things to do in Toronto', 'You\'re going to want to lace up because things to do in Toronto today include an ice skating party at Union Station\'s new outdoor rink. You can pick up some cozy Roots gear for cheap and there\'s lots of film, music, dancing and art to be had.\r\n\r\n', '2019-07-11'),
(8, 'Winter weather warning issued for Toronto', 'If there was ever a good day to plan on working from home, Friday would be... well, it would be one of those days. One of many, you can safely assume, over the next few months in Toronto.\r\n\r\nThe system is expected to move into Southern Ontario overnight, according to the Weather Network\'s Dr. Doug Gillham, bringing with it up to 10 cm of wet snow.', '2019-08-07'),
(9, 'I was not prepared for my four year old intense tantrums after his baby sister arrived', 'My four-year-old son screamed—a piercing shriek that echoed in my heart. It seemed directed at me: calibrated not only to express, but also to punish.\r\n\r\nMy offence? I’d just shuffled out of bed after nursing our two-month-old girl. Starving and parched in the primal way of a new nursing mother, I’d handed the baby to my husband, put the kettle on for tea. My son asked if I’d play with him. I said I’d love to, right after I ate.\r\n\r\nHe screamed, collapsed, wheeled on the floor, kicked a chair. My husband took the baby to our bedroom. We were learning the drill.\r\n\r\nThis had happened the day before, when I’d needed to use the bathroom after a trip to the park, and the day before that, when I’d wanted to change into pajamas.\r\n\r\nWe’d seen (and expected) outbursts in the nine weeks since my daughter was born, but they were growing in frequency and intensity like an alarm system.', '2020-08-03'),
(10, '5 ways you can reduce your family fashion footprint', 'The fashion industry accounts for around 10 percent of greenhouse gas emissions and around 20 percent of global waste water, a recent UN study found. Fast fashion accounts for most of these impacts—with more to come. For instance, according to the Ellen MacArthur Foundation—which works with businesses, governments and academia to build a more sustainable economy—each item of clothing was worn, on average, about 200 times in 2004, but by 2016, that number had decreased to 140. And if trends like these continue, the UN says by 2050 we may need almost three planets to provide the resources required to maintain current ways of life.\r\n\r\nI love fashion, but the true cost of clothing has replaced my enthusiasm for buying news things. While some activists, like Extinction Rebellion, call for a boycott on fast fashion, this isn’t always an option for those on limited budgets. The perfect carbon-neutral capsule wardrobe is simply out of reach for most Canadians. Luckily, there are easy things we can all do to reduce our fashion footprint', '2020-02-25'),
(11, 'Everything I learned about parenting I learned in puppy school', 'When I got my eight-year-old son, Quinn, to brush his teeth using a command we’d just learned in puppy class, I made a life-changing discovery: Puppy training doesn’t just work on puppies.\r\n\r\nIt was late evening (that is, way past bedtime), and Quinn was drumming his toothbrush against the mouthwash bottle with one hand while flying his Lego spaceship around the sink with the other. I was exasperated, and we were both exhausted—it was time for this guy to be in bed. I took a deep breath. ', '2020-10-17'),
(12, 'Meghan and Harry say baby Archie is crawling and has two teeth', 'Archie Harrison turned six months old on Nov. 6, and while they were out at Remembrance Day events that day, Duchess Meghan and Prince Harry told royal watchers and fans some awesome information about their little boy: He’s crawling and teething!\r\n\r\nThe Duke and Duchess of Sussex made a surprise visit at the Broom Farm Community Centre in Windsor to visit military families. It’s a short drive from the couple’s home of Frogmore Cottage, and while they were there, they met and spoke with the kin of armed services personnel currently stationed overseas.\r\n\r\nA sweet video posted to the couple’s SussexRoyal Instagram account shows Meghan kneeling down to speak with a young girl, who is holding an orange rose to give the duchess.', '2019-09-09');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `news`
--
ALTER TABLE `news`
  ADD PRIMARY KEY (`NEWSID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `news`
--
ALTER TABLE `news`
  MODIFY `NEWSID` int(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
