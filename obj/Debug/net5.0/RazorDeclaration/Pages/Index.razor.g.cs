// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ContactManagementSystem.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using ContactManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using ContactManagementSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Pages\Index.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Pages\Index.razor"
using ContactManagementSystem.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Pages\Index.razor"
       
    // list of contact objects
    List<Contact> ContactList;
    // indicates sort order
    private bool isSortedAscending;
    // keep track of column to sort by
    private string activeSortColumn;

    // pulls contacts from local database
    protected override async Task OnInitializedAsync()
    {
          using var context = contextFactory.CreateDbContext();
          ContactList = await context.Contacts.ToListAsync();
    }
    // re-direct to add contact page
    void addContact()
    {
        NavigationManager.NavigateTo("AddContact");
    }    

    // sort table by selected column
    private void SortTable(string columnName)
    {
        // sort ascending if not already sorted
        if (columnName != activeSortColumn)
        {
            ContactList = ContactList.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
            isSortedAscending = true;
            activeSortColumn = columnName;
        }
        else
        {
            if (isSortedAscending)
            {
                // sort descending if currently sorted ascending
                ContactList = ContactList.OrderByDescending(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
            }
            else
            {
                // sort ascending if currently sorted descending
                ContactList = ContactList.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
            }
            isSortedAscending = !isSortedAscending;
        }
    }

    // sets sort icon based on sort order
    private string SetSortIcon(string columnName)
    {
        if (activeSortColumn != columnName)
        {
            return string.Empty;
        }
        if (isSortedAscending)
        {
            return "fa-sort-up";
        }
        else
        {
            return "fa-sort-down";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<ContactDbContext> contextFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
