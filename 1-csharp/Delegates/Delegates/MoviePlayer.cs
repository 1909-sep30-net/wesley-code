﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Delegates
{
    public class MoviePlayer
    {
        public string CurrentMovie { get; set; }

        //events are entities that work on a publish-subcribe idea
        //c# lets you subscribe event handler delegates to events

        //the type for handling the event:
        public delegate void MovieFinishedHandler();
        //defines a delegate type for void-return and zero-parameters
        //this describes the shape of functions that can subscribe to this event i'm about to define

        public delegate void MovieFinishedHandlerWithDetails(string name);

        public event MovieFinishedHandlerWithDetails MovieFinished;

        public event Action<>

        public void PlayMovie()
        {
            Console.WriteLine($"Playing movie {CurrentMovie}");

            Thread.Sleep(3000);

            //fire the event (syntax looks just like calling a method)
            //what it effectively does is call all subscribing delegates

            //weird issue - if there are no subscribers, the event is kind of "null"
            /*if(MovieFinished != null)
                MovieFinished(CurrentMovie);*/
            MovieFinished?.Invoke(CurrentMovie); //does same thing as above code - do nothing if no subscribers

            //when you invoke the event, you have to pass the name of the event
        }
    }
}
