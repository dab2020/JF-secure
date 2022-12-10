Module Main
    Sub Main()

        ' The Introductory Block of Test and yes this time I am going to write comments for every thing, coz code that you wrote a month ago is a minefeild to pass through later
        Console.WriteLine("**********************************************************************")
        Console.WriteLine("           JF-Secure")
        Console.WriteLine("**********************************************************************")
        Console.WriteLine("           Created by Dab2020")
        Console.WriteLine("**********************************************************************")
        ' Sets the color to Red and Displays a warning message
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("JF-Secure IS PROVIDED 'As Is', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.")
        Console.ForegroundColor = ConsoleColor.Gray
        ' This waits 5 seconds before continuing so that the user can look at the above warning and then clears the screen
        Threading.Thread.Sleep(5000)
        Console.Clear()
        ' Using the inbuilt My.Settings saved data we can check if this is the first time the user is opening the application and based on this we can determine whether to Initiate the Setup Process

        If My.Settings.FirstRun Then
            My.Settings.FirstRun = False
            My.Settings.Save()
            ' Refers to FirstTimeSetup.vb sub (FTS)
            FTS()
        Else
            ' Because its not the first time that a user has opened the Program, it presensts options for actions
            Console.WriteLine("Hello Welome back to JF-Secure what would you like to do? (Enter Number Only)")
            Console.WriteLine("1. Run Startup Wizard (edit Config)")
            Console.WriteLine("2. Create Backup")
            Console.WriteLine("3. Uninstall Service")
            Dim arg As Integer
            Dim rprchk As Boolean
            rprchk = True
            ' rpchk is being used to make sure that the option entered is valid, The while loop allows for re-entry
            While rprchk
                arg = Console.ReadLine()
                Console.WriteLine("")
                Select Case arg
                    Case 1
                        rprchk = False
                        RemoveWinSSW()
                        FTS()
                    Case 2
                        rprchk = False
                        Savebackup()
                    Case 3
                        rprchk = False
                        RemoveWinSSW()
                    Case Else
                        MsgBox("Invalid Operator! Kindly Re-enter")
                End Select
            End While

        End If

        Console.ReadKey()
    End Sub
End Module
