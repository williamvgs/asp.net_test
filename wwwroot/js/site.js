// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function addItem() {
    var ul = document.getElementById("people");
    ul.innerHTML = ''; // Clear previous items
    @foreach (var user in Model.Results)
    {
        var li = document.createElement("li");
        li.textContent = user.Name.First + " " + user.Name.Last;
        ul.appendChild(li);
    }
}