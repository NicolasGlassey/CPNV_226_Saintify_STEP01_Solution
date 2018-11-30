using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace saintify.Business
{
    [TestClass]
    public class UnitTestArtist
    {

        #region private attributes
        private Artist artist = null;
        private String expectedArtistName = "Artist's Name";
        private String expectedArtistPictureName = "Artist's picture name";
        private List<Song> expectedArtistListOfSongs = null;
        #endregion private attributes

        /// <summary>
        /// This test method initializes variables and objects needed for the next test session.
        /// Run before each test method.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            this.expectedArtistListOfSongs = new List<Song>();
            for (int i = 0; i < 10; i++ )
            {
                Song song = new Song("Song" + i.ToString(), i+60);
                this.expectedArtistListOfSongs.Add(song);
            }
            artist = new Artist(this.expectedArtistPictureName, this.expectedArtistName,this.expectedArtistListOfSongs);
        }

        /// <summary>
        /// This test method is designed to test the Getter in charge to deliver the artist's picutre's name
        /// </summary>
        [TestMethod]
        public void TestMethodGetterActistPictureNameSucess()
        {
            //given
            //please refer to Init() method
            String actualArtistPictureName = "";

            //then
            actualArtistPictureName = this.artist.PictureName();

            //when
            Assert.AreEqual(this.expectedArtistPictureName, actualArtistPictureName);
        }

        /// <summary>
        /// This test method is designed to test the Getter in charge to deliver the artist's name
        /// </summary>
        [TestMethod]
        public void TestMethodGetterArtistNameSucess()
        {
            //given
            //please refer to Init() method
            String actualArtistName = "";

            //then
            actualArtistName = this.artist.Name();

            //when
            Assert.AreEqual(this.expectedArtistName, actualArtistName);
        }

        /// <summary>
        /// This test method cleanup variables and objects used for the last test session.
        /// Run after each test method.
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            this.artist = null;
        }
    }
}
