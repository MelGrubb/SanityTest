# SanityTest
I think I may have broken the web

This is the simplest example I could come up with. It is a straight out-of-the-box MVC5 project, with one new controller/viewModel/view in it. The view has five select lists rendered via Html.DropDownLostFor. The controller hands back a hard-wired viewmodel with the values [null, 1, null, 2, null] in it. The list of SelectListItems has five values in it as well. The first has an empty string for a value and "Select" for its text, the others have values from 1 to 4 with corresponding text.

When the page is rendered, you would expect the drop-downs to display the values [Select, Value 1, Select, Value 2, Select], but instead they render as [Select, Value 1, Value 1, Value 2, Value 2]. Each drop-down bound to a null value in the viewmodel displays the value from the previous drop-down on the page.

I thought at first that Bootstrap or jQuery might be to blame, but a quick check with Fiddler shows that the page is being returned from the server this way.

Disclaimer: I'm afraid I could be overlooking something terribly obvious or embarassingly remedial. I fully acknowledge that this might be the case. The answer could be staring me in the face, and I'm just too far down the rabbit hole to notice, but this behavior seems dangerously incorrect to me.
