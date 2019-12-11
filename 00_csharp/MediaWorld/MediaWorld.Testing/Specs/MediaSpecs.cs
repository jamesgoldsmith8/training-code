using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Factories;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;
using Moq;
using Xunit;

namespace MediaWorld.Testing.Specs
{
    public class MediaSpec
    {
        AudioFactory af = new AudioFactory();
        VideoFactory vf = new VideoFactory();

        Mock<AMedia> mock;

        public MediaSpec()
        {
            mock = new Mock<AMedia>();
            mock.Setup(am => am.Play()).Returns(false);
        }

        [Fact]
        public void Test_AudioObject()
        {
            // Arrange
            var sut = af;
            var expected = typeof(Song);

            // Act
            var actual = af.Create<Song>();

            // Assert
            Assert.True(expected == actual.GetType());
        }   

        [Fact]
        public void Test_VideoObject()
        {
            var sut = vf;
            var expected = typeof(Movie);

            var actual = vf.Create<Movie>();

            Assert.True(expected == actual.GetType());

        }

        [Fact]
        public void Test_VideoPlay()
        {
            var sut = MediaSingleton.Instance;
            var mm = mock.Object;

            Assert.True(sut.Execute(mm.Play, mm));
        }
    }
}