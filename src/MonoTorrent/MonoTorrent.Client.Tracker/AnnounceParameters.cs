//
// AnnounceParameters.cs
//
// Authors:
//   Alan McGovern alan.mcgovern@gmail.com
//
// Copyright (C) 2008 Alan McGovern
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//


using MonoTorrent.BEncoding;

namespace MonoTorrent.Client.Tracker
{
    public class AnnounceParameters
    {
        public long BytesDownloaded { get; }
        public long BytesLeft { get; }
        public long BytesUploaded { get; }
        public TorrentEvent ClientEvent { get; }
        public InfoHash InfoHash { get; }
        public string IPAddress { get; }
        public BEncodedString PeerId { get; }
        public int Port { get; }
        public bool RequireEncryption { get; }
        public bool SupportsEncryption { get; }

        public AnnounceParameters ()
        {

        }

        public AnnounceParameters (long bytesDownloaded, long bytesUploaded, long bytesLeft,
                           TorrentEvent clientEvent, InfoHash infoHash, bool requireEncryption,
                           BEncodedString peerId, string ipAddress, int port, bool supportsEncryption)
        {
            BytesDownloaded = bytesDownloaded;
            BytesUploaded = bytesUploaded;
            BytesLeft = bytesLeft;
            ClientEvent = clientEvent;
            InfoHash = infoHash;
            RequireEncryption = requireEncryption;
            PeerId = peerId;
            IPAddress = ipAddress;
            Port = port;
            SupportsEncryption = supportsEncryption;
        }

        public AnnounceParameters WithBytesDownloaded (long bytesDownloaded)
        {
            return bytesDownloaded == BytesDownloaded ? this : new AnnounceParameters (bytesDownloaded, BytesUploaded, BytesLeft, ClientEvent, InfoHash, RequireEncryption, PeerId, IPAddress, Port, SupportsEncryption);
        }

        public AnnounceParameters WithBytesLeft (long bytesLeft)
        {
            return bytesLeft == BytesLeft ? this : new AnnounceParameters (BytesDownloaded, BytesUploaded, bytesLeft, ClientEvent, InfoHash, RequireEncryption, PeerId, IPAddress, Port, SupportsEncryption);
        }

        public AnnounceParameters WithBytesUploaded (long bytesUploaded)
        {
            return bytesUploaded == BytesUploaded ? this : new AnnounceParameters (BytesDownloaded, bytesUploaded, BytesLeft, ClientEvent, InfoHash, RequireEncryption, PeerId, IPAddress, Port, SupportsEncryption);
        }

        public AnnounceParameters WithClientEvent (TorrentEvent clientEvent)
        {
            return clientEvent == ClientEvent ? this : new AnnounceParameters (BytesDownloaded, BytesUploaded, BytesLeft, clientEvent, InfoHash, RequireEncryption, PeerId, IPAddress, Port, SupportsEncryption);
        }

        public AnnounceParameters WithInfoHash (InfoHash infoHash)
        {
            return infoHash == InfoHash ? this : new AnnounceParameters (BytesDownloaded, BytesUploaded, BytesLeft, ClientEvent, infoHash, RequireEncryption, PeerId, IPAddress, Port, SupportsEncryption);
        }

        public AnnounceParameters WithIPAddress (string ipAddress)
        {
            return ipAddress == IPAddress ? this : new AnnounceParameters (BytesDownloaded, BytesUploaded, BytesLeft, ClientEvent, InfoHash, RequireEncryption, PeerId, ipAddress, Port, SupportsEncryption);
        }

        public AnnounceParameters WithPeerId (BEncodedString peerId)
        {
            return peerId == PeerId ? this : new AnnounceParameters (BytesDownloaded, BytesUploaded, BytesLeft, ClientEvent, InfoHash, RequireEncryption, peerId, IPAddress, Port, SupportsEncryption);
        }

        public AnnounceParameters WithPort (int port)
        {
            return port == Port ? this : new AnnounceParameters (BytesDownloaded, BytesUploaded, BytesLeft, ClientEvent, InfoHash, RequireEncryption, PeerId, IPAddress, port, SupportsEncryption);
        }

        public AnnounceParameters WithRequireEncryption (bool requireEncryption)
        {
            return requireEncryption == RequireEncryption ? this : new AnnounceParameters (BytesDownloaded, BytesUploaded, BytesLeft, ClientEvent, InfoHash, requireEncryption, PeerId, IPAddress, Port, SupportsEncryption);
        }

        public AnnounceParameters WithSupportsEncryption (bool supportsEncryption)
        {
            return supportsEncryption == SupportsEncryption ? this : new AnnounceParameters (BytesDownloaded, BytesUploaded, BytesLeft, ClientEvent, InfoHash, RequireEncryption, PeerId, IPAddress, Port, supportsEncryption);
        }
    }
}
