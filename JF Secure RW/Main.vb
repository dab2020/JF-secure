Imports System
Imports System.IO
Imports FirstTime
Module Main
    Sub Main()

        ' The Introductory Block of Test and yes this time I am going to write comments for every thing, coz code that you wrote a month ago is a minefeild to pass through
        Console.WriteLine("**********************************************************************")
        Console.WriteLine("           JF-Secure")
        Console.WriteLine("**********************************************************************")
        Console.WriteLine("           Created by Dab2020")
        Console.WriteLine("**********************************************************************")
        ' Sets the color to Red and Displays a warning message
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("JF-Secure IS PROVIDED 'As Is', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.")
        Console.ForegroundColor = ConsoleColor.Gray
        Console.WriteLine("Press any Key to procede....")
        Console.ReadKey()
        Dim firstset As New Setup()
        ' Using the inbuilt My.Settings saved data we can check if this is the first time the user is opening the application and based on this we can determine whether to Initiate the Setup Process
        If My.Settings.FirstRun Then
            My.Settings.FirstRun = False
            firstset.FirstTime()
        Else

        End If
        Console.Clear()
        Console.ReadKey()
    End Sub
End Module
