using GamesLibrary.Battleships;
using Xunit;

namespace GamesLibraryTests.Battleships
{
	public class BoardMakerTests
	{
		private BoardMaker Subject;

		public BoardMakerTests()
		{
			Subject = new BoardMaker();
		}

		[Fact]
		public void WhenInstantiatingTheBoardMaker_ItShouldNotReturnNull()
		{
			Assert.NotNull(Subject);
		}

		[Fact]
		public void WhenExecuting_ItShouldReturnAPlayingBoardBoard()
		{
			var result = Subject.Execute();

			Assert.NotNull(result);
			Assert.IsType<PlayingBoard>(result);
		}

		[Fact]
		public void WhenExecuting_ItShouldDefineTheBoardBoundaries()
		{
			var expected = 10;

			Assert.Equal(expected, Subject.BoardWidth);
			Assert.Equal(expected, Subject.BoardHeight);
		}
	}
}