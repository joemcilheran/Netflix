using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    
    public class Catalogue: IEnumerable
    {
        public List<Genre> genreList;
        private List<Title> allTitlesList;
        public List<Title> AllTitlesList
        {
            get
            {
                return allTitlesList;
            }
        }
        public Catalogue()
        {
            Episode amokTime = new Episode("amok time", 5);
            Episode whoMournAdonis = new Episode("who mourns adonis", 2);
            Episode theChangling = new Episode("the changling", 3);
            Episode mirrorMirror = new Episode("mirror, mirror", 4);
            Episode theApple = new Episode("the apple", 2);
            Episode doomsdayMachine = new Episode("doomsday machine", 4);
            Episode catspaw = new Episode("catspaw", 3);
            Episode iMudd = new Episode("i, mudd", 4);
            Episode metamorphosis = new Episode("metamorphosis", 3);
            Episode journeyToBabel = new Episode("journey to babel", 5);
            List<Episode> starTrekList = new List<Episode>() {amokTime,whoMournAdonis,theChangling,mirrorMirror,theApple,doomsdayMachine,catspaw,iMudd,metamorphosis,journeyToBabel };
            Episode daysGoneBye = new Episode("days gone bye", 4);
            Episode guts = new Episode("guts", 3);
            Episode tellItToTheFrogs = new Episode("tell it to the frogs", 4);
            Episode vatos = new Episode("vatos", 2);
            Episode wildfire = new Episode("wildfire", 5);
            List<Episode> theWalkingDeadList = new List<Episode>() {daysGoneBye,guts,tellItToTheFrogs,vatos,wildfire};
            Episode moleHunt = new Episode("mole hunt", 3);
            Episode trainingDay = new Episode("training day", 4);
            Episode diversityHire = new Episode("diversity hire", 2);
            Episode killingUtne = new Episode("killing utne", 4);
            Episode honeyPot = new Episode("honey pot", 3);
            Episode skorpio = new Episode("skorpio", 3);
            Episode skytanic = new Episode("skytanic", 5);
            Episode theRock = new Episode("the rock", 4);
            Episode jobOffer = new Episode("job offer", 5);
            List<Episode> archerList = new List<Episode>() {moleHunt,trainingDay,diversityHire,killingUtne,honeyPot,skorpio,skytanic,theRock,jobOffer};
            Episode takeYourLittleGun = new Episode("take your little gun", 4);
            Episode fuckCommunityCollege = new Episode("fuck community college", 3);
            Episode mrLaney = new Episode("mr laney", 4);
            Episode peterson = new Episode("peterson", 3);
            Episode imNotGay = new Episode("i'm not gay", 4);
            Episode whoTheHell = new Episode("who the hell", 3);
            List<Episode> trailorParkBoysList = new List<Episode>() {takeYourLittleGun,fuckCommunityCollege,mrLaney,peterson,imNotGay,whoTheHell};
            Episode itBegins = new Episode("it begins", 4);
            Episode oneLongDay = new Episode("one long day", 4);
            Episode tested = new Episode("tested", 3);
            Episode party = new Episode("party", 3);
            Episode date = new Episode("date", 5);
            Episode andy = new Episode("andy", 5);
            Episode magic = new Episode("magic", 3);
            Episode closingSong = new Episode("closing song", 5);
            Episode theTableRead = new Episode("the table read", 3);
            Episode theEndOfTheBeginning = new Episode("the end of the beginning", 4);
            List<Episode> loveList = new List<Episode>() {itBegins,oneLongDay,tested, party,date,andy,magic,closingSong,theTableRead,theEndOfTheBeginning};
            //action
            Show starTrek = new Show("star trek",starTrekList,"action");
            Show theWalkingDead = new Show("the walking dead",theWalkingDeadList,"action");
            Movie sahara = new Movie(124, 3, "sahara", "action");
            Movie admiral = new Movie(128, 4, "admiral", "action");
            Movie braveheart = new Movie(177, 5, "braveheart", "action");
            Movie bloodsport = new Movie(92, 4, "bloodsport", "action");
            Movie djangoUnchained = new Movie(165, 4, "django unchained", "action");
            //action comedie
            Movie theReplacements = new Movie(158, 4, "the replacements", "action");
            Movie shanghaiKnights = new Movie(114, 3, "shanghai knights", "comedy");
            Show archer = new Show("archer",archerList, "action");
            //romantic action
            Movie thePrincessBride = new Movie(98, 5, "the princess bride","action");
            Movie toCatchAThief = new Movie(116, 5, "to catch a thief", "romance");
            //comedy
            Movie specialCorrespondents = new Movie(101, 3, "special correspondents","comedy");
            Movie talladegaNights = new Movie(97, 4, "talladega nights", "comedy");
            Movie harryAndTheHendersons = new Movie(110, 4, "haryy and the hendersons", "comedy");
            Movie waynesWorld = new Movie(94, 5, "wayne's world", "comedy");
            Movie theMoneyPit = new Movie(90, 4, "the money pit", "comedy");
            Movie bestInShow = new Movie(90, 5, "best in show", "comedy");
            Show trailorParkBoys = new Show("trailor park boys",trailorParkBoysList, "comedy");            
            //romantic comedy
            Movie justFriends = new Movie(94, 3, "just friends", "comedy");
            Movie sixteenCandles = new Movie(94, 5, "sixteen candles", "romance");
            Show love = new Show("love",loveList, "comedy");
            //romance
            Movie saveTheLastDance = new Movie(122, 4, "save the last dance", "romance");
            Movie beforeWeGo = new Movie(95, 4, "before we go", "romance");
            Movie romanHoliday = new Movie(118, 5, "roman holiday", "romance");
            Movie acrossTheUniverse = new Movie(133, 4, "across the universe", "romance");
            Movie anAffairToRemember = new Movie(114, 5, "an affair to remember", "romance");
            List<Title> comedyList = new List<Title>() { love,specialCorrespondents, talladegaNights, harryAndTheHendersons, waynesWorld, theMoneyPit, bestInShow, trailorParkBoys, archer, justFriends, sixteenCandles, theReplacements, shanghaiKnights };
            List<Title> actionList = new List<Title>() { sahara, admiral, braveheart, bloodsport, djangoUnchained, starTrek, theWalkingDead, theReplacements, thePrincessBride, shanghaiKnights, archer, toCatchAThief };
            List<Title> romanceList = new List<Title>() { love, saveTheLastDance, beforeWeGo, romanHoliday, acrossTheUniverse, anAffairToRemember, toCatchAThief,thePrincessBride,justFriends,sixteenCandles };
            allTitlesList = new List<Title>() { love, specialCorrespondents, talladegaNights, harryAndTheHendersons, waynesWorld, theMoneyPit, bestInShow, trailorParkBoys, archer, justFriends, sixteenCandles, theReplacements, shanghaiKnights, sahara, admiral, braveheart, bloodsport, djangoUnchained, starTrek, theWalkingDead, saveTheLastDance, beforeWeGo, romanHoliday, acrossTheUniverse, anAffairToRemember, toCatchAThief, thePrincessBride };
            Genre comedy = new Genre(comedyList, "comedy");
            Genre romance = new Genre(romanceList,"romance");
            Genre action = new Genre(actionList,"action");
            genreList = new List<Genre>() {comedy, romance, action};

        }
        public IEnumerator GetEnumerator()
        {
            foreach (Genre genre in genreList)
            {
                yield return genre;
            }
        }



    }
}
