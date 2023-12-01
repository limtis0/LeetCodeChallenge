param (
    [string]$name,
    [string]$directory = $PWD
)

if (-not $name) {
    Write-Host "Usage: CreateChallenge.ps1 -name <ChallengeName> [-directory <TargetDirectory>]"
    exit 1
}

$fullPath = Join-Path $directory $name
$file = Join-Path $fullPath "$name.cs"
$testFile = Join-Path $fullPath "Test$name.cs"

# Create directory
New-Item -ItemType Directory -Path $fullPath

# Create main file
@"
namespace LeetCodeChallenge;

// #. URL
public class $name
{
    public static void Solution()
    {
    }
}
"@ | Out-File $file

# Create test file
@"
namespace LeetCodeChallenge;

[TestClass]
public class Test$name
{
    [TestMethod]
    public void Test1()
    {
        // Arrange
        int param = 1;
        
        int expected = 1;

        // Act
        int actual = $name.Solution(param);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
"@ | Out-File $testFile

Write-Host "Challenge '$name' created successfully in '$fullPath'!"
