using GamesLibrary.Battleships;
using Xunit;

namespace GamesLibraryTests.Battleships
{
	public class BoardMakerTests
	{
		private BoardMaker Subject;

		[Fact]
		public void WhenInstantiatingTheBoardMaker_ItShouldNotReturnNull()
		{
			Subject = new BoardMaker();

			Assert.NotNull(Subject);
		}
	}
}