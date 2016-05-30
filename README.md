# Octree-Implementation

<strong>Breif</strong>
<br/>An octree implementation + application on images. A project I did back in 2011.

<strong>Hierarchy</strong>
<br/>In this implementation of Quadtree, you can find different trees. These differs of the way it collapse/reduce the nodes:
<ol>
<li/>OctreeBalancedLeastC7LCollapsing
<li/>OctreeBalancedLeastCAllCollapsing
<li/>OctreeBalancedLeastVAllSidesCollapsing
<li/>OctreeUnBalancedLeastChilds
<li/>OctreeUnBalancedLeastV1SideCollapsing: Least visited + collapse one side.
</ol>
<br/>The hierarchy is like this:
![alt tag](https://raw.githubusercontent.com/ZGTR/Octree-Implementation/ScreenShots/master/Picture_0.png)

<strong>Mapping Functions in Images</strong>
<ol>
<li/>ColorComponent: distance according to R OR G OR B.
<li/>ColorComponentsSum: distance according to R AND G AND B.
<li/>ColorWeightedComponentSum: distance according to w_r * R AND w_g * G AND w_b * B. You can play with weights as you like. Humans eyes catches R the most though. 
<li/>EcludianDistanceARGB: Ecludian distance between the sums of RGB.
<li/>EcludianDistanceColorComponents: Ecludian distance between the RGB.
</ol>

<strong>UI</strong>
<br/>Using WPF, the user is greeted with:
![alt tag](https://raw.githubusercontent.com/ZGTR/Octree-Implementation/ScreenShots/master/Picture0.png)

<br/>For each compressed image, a new entity is added to show the difference:
![alt tag](https://raw.githubusercontent.com/ZGTR/Octree-Implementation/ScreenShots/master/Picture1.png)

<br/>You can resize the images as you like:
![alt tag](https://raw.githubusercontent.com/ZGTR/Octree-Implementation/ScreenShots/master/Picture2.png)

<br/>You can also see the color histogram for each:
![alt tag](https://raw.githubusercontent.com/ZGTR/Octree-Implementation/ScreenShots/master/Picture3.png)
