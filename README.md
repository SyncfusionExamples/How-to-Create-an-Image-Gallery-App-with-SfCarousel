# How to Create an Image Gallery App with SfCarousel

This demo shows how to build an image gallery app in the .NET MAUI SfCarousel control.

This section explains how to create a swipeable image gallery that displays a collection of tourist destinations using the .NET MAUI SfCarousel control. The carousel is bound to a collection of places and renders each image as a rounded card with an overlay caption, making it ideal for showcasing travel photos, featured content, or any visual gallery in your application.

The SfCarousel control is data-driven, so the images displayed in the gallery are generated dynamically from the bound collection. This approach helps create flexible, data-driven, and visually rich user interfaces while keeping the UI implementation clean and maintainable.

In this example, the gallery loads a collection of iconic tourist destinations (such as the Eiffel Tower, Venice Canal, Santorini, Maldives Beach, and Swiss Alps) and renders them as swipeable cards. Each card uses a soft gradient background, rounded corners, a drop shadow, and a semi-transparent overlay that displays the destination title, country, rating, and a featured tag on top of the image.

## Key Highlights

- Displays a swipeable image gallery using the SfCarousel control.
- Renders each image as a rounded card with an overlay caption.
- Uses data binding to populate the gallery from an ObservableCollection.
- Supports a custom DataTemplate to fully control the visual layout of each item.
- Applies a soft gradient background, drop shadow, and rounded corners for a modern look.
- Built on the MVVM pattern for a clean separation of data and UI.

By following the implementation steps, you can easily customize the appearance of each gallery item and create rich image browsing experiences based on your application data.
