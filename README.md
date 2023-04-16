# FigureAreaCalculator

![Build and test workflow](https://github.com/ksydex/figure_area_calculator_lib/actions/workflows/dotnet.yml/badge.svg)
[![NuGet](https://img.shields.io/nuget/v/Ksydex.Figure.svg)](https://www.nuget.org/packages/Ksydex.Figure/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Ksydex.Figure.svg)](https://www.nuget.org/packages/Ksydex.Figure/)


The `Ksydex.Figure` namespace provides classes for representing various geometric figures, including triangles and circles.

## Installation

This package is available on [NuGet](https://www.nuget.org/packages/Ksydex.Figure/). You can install it using the following command:

```
dotnet add package Ksydex.Figure
```

## Usage

To use the `Ksydex.Figure` namespace in your project, simply add a reference to the `Ksydex.Figure` package and use the classes provided:

```csharp
using Ksydex.Figure;

var triangle = new Triangle(3, 4, 5);
var circle = new Circle(2);

var triangleArea = triangle.Area;
var circleArea = circle.Area;
```

API Reference
-------------

### `Ksydex.Figure.Interfaces.IFigure`

Represents a geometric figure with an area.

#### Properties

-   `Area` (double): Gets the area of the figure.

### `Ksydex.Figure.Figures.Triangle`

Represents a triangle.

#### Constructors

-   `Triangle(double a, double b, double c)`: Initializes a new instance of the `Triangle` class with the specified side lengths.

#### Properties

-   `Area` (double): Gets the area of the triangle.
-   `IsRightAngled` (bool): Gets a value indicating whether the triangle is a right angled triangle.

#### Exceptions

-   `ArgumentException`: Thrown if any of the side lengths are less than or equal to zero, or if the sum of any two sides is less than or equal to the third side.

### `Ksydex.Figure.Figures.Circle`

Represents a circle.

#### Constructors

-   `Circle(double radius)`: Initializes a new instance of the `Circle` class with the specified radius.

#### Properties

-   `Area` (double): Gets the area of the circle.

#### Exceptions

-   `ArgumentException`: Thrown if the radius is less than or equal to zero.

# Contributing
Contributions are welcome! If you find a bug or would like to suggest a new feature, please open an issue or submit a pull request.

# License
This package is licensed under the MIT License.
