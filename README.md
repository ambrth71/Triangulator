Triangulator is an implementation of Dave Eberly's ear clipping algorithm as described here: http://www.geometrictools.com/Documentation/TriangulationByEarClipping.pdf. The project allows you to simply input a list of vertices and get back the required vertices (in order) and indices needed to construct a VertexBuffer and IndexBuffer for rendering the particular shape. The library is able to cut holes inside of polygons without error (the only caveat to this is that the library assumes that the hole to be cut lies completely within the shape so erroneous data given as a hole will result in invalid output data).

Note: Triangulator is set up to write a good amount of verbose output in Debug mode. This will affect performance. For optimal performance, make sure you are building the library in Release mode or modify the source to remove the logging functionality.

--------------------------------------

Project modified to work with Visual Studio 2019 and .NET framework 4.7.2

Fixed a few issues with holes management

--------------------------------------

1. DetermineWindingOrder

Instead of counting individual positive/negative winding points, sum the amount of winding for each point (angle between vectors).
So many points with a small angle won't have more weight than few points with a large angle for the winding.

2. CutHoleInShape

Multiple holes management:
Manage ray intersection with junction segments of holes cut previously in the initial shape (2 identical segments). The correct intersection is supposed to be the second one because of the shape winding before adding the new hole.

Shape point on ray:
When a point of the shape is found on the ray used to find the closest intersection point to a hole, it's the one to consider for hole injection.

Added conditions to select points with maximum Y when points with same X are found in right most hole vertices and closest segment to hole.

---------------------------------------

Important assumption:
Since the holes are joined from their rightmost point to segments facing it on its right, it's assumed that holes are sorted by their rightmost point (maximum X) descending when added to the initial shape. When holes have the same maximum X, then they are sorted by their bottommost point (minimum Y) ascending.
