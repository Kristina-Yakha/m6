using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Iterator
{
    public class ChannelIteratorNormal : IChannelIterator
    {
        private List<Channel> channels;
        private int currentPosition = 0;

        public ChannelIteratorNormal(List<Channel> channels) //constru
        {
            this.channels = channels;
            
        }

        public bool HasNext()
        {
            if (currentPosition < channels.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Channel Next()
        {
            return channels[currentPosition++]; 
        }

        public void ShuffleList<T>()
        {
            Random rnd = new Random();
          
            int numChannels = channels.Count;
            while (numChannels > 1) {
                numChannels--;
                int randomChannel = rnd.Next(numChannels + 1);
                Channel value = channels[randomChannel];
                channels[randomChannel] = channels[numChannels];
                channels[numChannels] = value;

            }
            

        }

   


    }
}

