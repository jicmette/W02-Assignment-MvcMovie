# MvcMovie Project

This project follows the ASP.NET Core MVC tutorial and includes additional functionality for the assignment.

## Features
- **Custom App Title**: Changed to *Israel Movies* in the layout.
- **Favorite Movies**: Seeded at least 3 personal favorites with ratings.
- **Listing Title**: Index page renamed to *My Movies*.
- **Search & Filter**:
  - Case-insensitive title search.
  - Optional year filter (movies released in or after the entered year).
- **New Field**: Added `Rating` to the Movie model, included in Create/Edit/Details/Delete views.
- **Validation**: DataAnnotations enforce rules for Title, Genre, Price, and Rating.
- **Styling**:
  - Added padding to form inputs (input, select, textarea).
- **CRUD Completed**: Create, Read (Details), Update (Edit), Delete all implemented.

## How to Use
- Navigate to `/Movies` to view the list.
- Use the search box and year filter to refine results.
- Add new movies with the Create form (validation enforced).
- Edit, view details, or delete movies using the action buttons.