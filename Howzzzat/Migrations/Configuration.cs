namespace Howzzzat.Migrations
{
    using Howzzzat.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Howzzzat.Models.HowzatContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Howzzzat.Models.HowzatContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Articles.AddOrUpdate(
                p => p.id,
                new Article
                {
                    Author = "AHMER NAQVI",
                    Title = "Why Mitchell Johnson fails the hipster test",
                    Content = @"At its heart, the whole point of hipsters is not about being counter-culture, but rather laying claim to authenticity. You can't be a hipster if you jumped on a bandwagon or showed up without appreciating what you were there for. A hipster is authentic because an authentic experience means being there before it was cool and marketed. Consequently, while the rest of the world treats fast bowling as a seasonal fad, for Pakistanis it is more like l'bowling rapide pour l'bowling rapide.

As soon as I decided that I belonged to this ridiculous category, I realised I would need some codes to define what kinds of things fast-bowling hipsters, at least the ones from the Pakistani school of thought, would look for. The first person I turned to for inspiration was Osman Samiuddin, the high priest of the Pakistani fast-bowling cult.",
                    DatePublished = DateTime.Now,
                    Stat = new ArticleStats()
                },
                new Article
                {
                    Author = "DAVE HAWKSWORTH",
                    Title = "England need to embrace being dull",
                    Content = @"In reality, England aren't quite as dull as they are being made out to be. They simply play to their strengths and a fairly straightforward game plan. A four-man attack, drilled to apply pressure by not giving away cheap runs, backed by good catchers and fields set to deny the opposition their favourite scoring areas. Seven front-line batsmen; a top three who can wear down bowlers and play long innings; Pietersen, Bell and Prior to come in later and play a more expansive game. It's not rocket science. It's not particularly sexy. But in the past it has worked.

Trouble is, as with any game plan, take out a few key elements - your metronomic No. 3 loses form, your underrated first-change seamer gets injured - and things start to go wrong. And when things start to go wrong on tour they can quickly spiral out of control.

In this case they have spiralled into two of the more abject England Test performances in recent memory. Catches have been dropped, run-out opportunities missed, bowling rendered impotent on pitches that Australia have exploited to take 20 wickets, batting blown away by a cricketer taking great pleasure in ramming the ridicule of English supporters down the throats of English batsmen.

On the last Ashes tour, England had seemed like they were batting on cruise control. Arm out of the window, radio on, no worries mate, we'll get these runs at our own pace. This time round, against Australia's resurgent pace attack, England have found every gear but the right one. Either letting the game drift by as they try to duck out of the way of the coming onslaught, or overcompensating by providing catching practice in the outer. Collectively, they simply haven't played the short ball well enough.

This isn't the first time England's batting has been in crisis since Flower has been coach. At the start of 2012 he presided over a 3-0 series thrashing by Pakistan in the UAE. No one scored a century. No one looked like they could. Saeed Ajmal and Abdur Rehman ripped the ball past the edge of English bats time and again. Whenever England faced them it felt like you were watching a cop clinging to the bonnet of a speeding getaway car.",
                    DatePublished = DateTime.Now,
                    Stat = new ArticleStats()
                },
                new Article
                {
                    Author = "JON HOTTEN",
                    Title = "Close, Chappell and acts of courage",
                    Content = @"That 20 at Old Trafford was Close's final Test innings, bookending a career that began at 18 and ended at 45. Only Wilfred Rhodes has had more time between his first Test and his last.

The brutality that Close confronted at Old Trafford is only hinted at on film and in the sonorous declamation from the Almanack: The period before the close of the third day brought disquieting cricket as Close and Edrich (his opening partner) defended themselves against fast bowling which was frequently too wild and hostile to be acceptable.

On a decaying wicket it was both awesome and terrible in its ferocity, and the batsmen displayed sporting courage of the highest kind. Close survived 108 balls and almost three hours, at one point facing Holding for more than 40 minutes without a change of ends. He refused to be broken by the onslaught, or by the hopeless situation of the match - England had been bowled out for 71 in their first innings, with Woolmer and Hayes dismissed by balls that Wisden records as unplayable and Greig and Underwood having narrow escapes from what could have been serious injury. They were 552 behind when Close and Edrich went in for a second time. It was heroic in its way, defiant and brave and doomed, and it's hard not to be moved by the sight of it.

Mike Selvey sensed that Cook's England were facing pace that echoed a previous era, in a brilliant piece for the Guardian about Greg Chappell's method during the Packer years.",
                    DatePublished = DateTime.Now,
                    Stat = new ArticleStats()
                },
                new Article
                {
                    Author = "PAUL FORD",
                    Title = "University Oval utopia",
                    Content = @"On Friday we hunted some shade as the mercury in this little slice of southern paradise ticked past 20 degrees Celsius, and found ourselves nestled in a shady hedge, where chief groundsman Tom Tamati and his band of eerily similar-looking cohorts were settling in with their Vegemite sandwiches.

The old blokes nearby regaled us with the controversial story of the slicing and relocation of the former art gallery, built for the 1925 New Zealand and South Seas International Exhibition, in order to keep the ICC happy and stop cricketers like Daniel Vettori criticising the ground's set-up as farcical.

The news of Nelson Mandela's death reverberated around the ground. The minute's silence after lunch was a nice touch from NZ Cricket, and the respectful hush for Madiba was only punctured by a little kid who had a few questions for his mum.

In the crowd there was an eclectic mix of families, a chap who looked like Bruce Dickinson from Iron Maiden, talented school kids with cricket bats, a guy with an umbrella taped to his back, and hardcore fans in fold-out deckchairs. It was nice to see a pleasing smattering of men in beige, but my player of the day was the old chap who was not partaking in the free sunscreen being dispensed willy-nilly around the ground. Instead he elected to fold a mini paper dart and held it on the bridge of his nose with his spectacles like it was the most normal thing ever.",
                    DatePublished = DateTime.Now,
                    Stat = new ArticleStats()
                },
                new Article
                {
                    Author = "RAF NICHOLSON",
                    Title = "What if Sachin had been a girl?",
                    Content = @"The ECB's press release drops under the radar, almost unobserved. Colvin's break from cricket cannot compete with the Little Master's last journey back to the pavilion. (Can anything?)

That is the way it goes. Because Sachin has been worshipped as a demi-god for the last 24 years, and Colvin is merely a female cricketer. To illustrate the point: Sachin's last Test innings was played at his home ground, the Wankhede Stadium in Mumbai, to a sell-out crowd of 45,000. Others, who did not get lucky in the ticket lottery, lined the streets outside the ground. The last time Colvin was scheduled to play in a match at the Wankhede - during the women's World Cup, back in February - the match was moved at the last minute to make way for a Ranji Trophy match featuring Sachin and his Mumbai team-mates.

There are parallels between the two careers, perhaps. It was Sachin's brilliance at such a young age that initially caught the attention of the cricketing world. His international debut at age 16, against Pakistan in Karachi, is the stuff of legend. And if young brilliance is what excites cricket fans, Colvin's 2005 debut should get a mention too - less well-known, but no less remarkable for all that. Rumour has it that she was drafted into the England side at the last minute, by virtue of turning up to help out at a net session. England were playing Australia; Colvin took three wickets in her first Test match, and narrowly missed out on a hat-trick. England drew the match, and went on to win the Ashes for the first time in 42 years. She was only 15 at the time.

Sachin has been the cornerstone of the most successful period of Indian cricket of all time. Colvin, too, has been a cornerstone of possibly the most successful England women's team ever, a side that in 2009 won the Ashes, the World Twenty20 and the 50-over World Cup in the course of just five months. Both players have consistently been at the top or near the top of the ICC's player rankings in their respective arts.",
                    DatePublished = DateTime.Now,
                    Stat = new ArticleStats()
                },
                new Article
                {
                    Author = "NICHOLAS HOGG",
                    Title = "The comeback",
                    Content = @"So can England 2013 muster and regroup? In the fabled 2005 series they came back from a first-game defeat at Lord's with a stirring victory at Edgbaston. The team was packed to the rafters with fighting tyros - Flintoff, Jones, Harmison and Hoggard, along with wheelie bin Ashley Giles engineering his comeback against the press jibes that he wasn't up to international standards. Giles may have only bagged three wickets in the first innings, but those scalps were Ponting, Clarke and Warne. Whilst the current squad as a whole must rearm - the testing No. 3 spot will surely be filled by either Root or Bell - cricket is a team game fought man to man. The fightback is ultimately up to individuals. Each batsman must stare down his bowling foe, as each bowler must hunt down his wicket. In cricket, unlike many other team sports, one player can win a game single-handedly.Arguably, one of the greatest ever Test comebacks must be India versus Australia in Kolkata in 2001, when a fine Steve Waugh century was diminished by a mighty 281 by VVS Laxman - ably partnered by a plucky 180 by Rahul Dravid - inspiring Harbhajan Singh to match-winning figures of 6 for 73 and the most unlikely Indian victory. Laxman, though supported by his rallied troops, won the game. As did Botham at Headingley in 1981. True, he needed Willis to gallop down the slope and kick away the Aussie stumps, but the bloodlust had been spiked by the Botham bravura.",
                    DatePublished = DateTime.Now,
                    Stat = new ArticleStats()
                }
                );
        }
    }
}
