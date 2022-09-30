* {
  margin: 0px;
  border: 0px;
}

body {
  background-color: rgb(191, 247, 247);
}

nav {
  display: flex;
  flex-direction: row;
  justify-content: space-around;
  border: 2px solid black;
  padding: 20px;
}

a {
  color: pink;
  text-decoration: none;
}

a:hover {
  color: hotpink;
}

h2 {
  color: hotpink;
  font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
}

p {
  color: pink;
  font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
}

.Home {
  padding: 100px;
  margin: 100px;
  display: flex;
  flex-direction: column;
  justify-content: flex-end;
  align-items: flex-end;
}
.Home__title {
  color: pink;
  font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
}
.Home__subtitle {
  color: hotpink;
  font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
}

.Skills {
  display: flex;
  flex-direction: row;
  justify-content: space-around;
  padding: 60px;
  margin: 60px;
}

.Projects {
  display: flex;
  flex-direction: row;
  justify-content: space-around;
  padding: 60px;
  margin: 60px;
}
.Projects__title {
  color: hotpink;
}
.Projects__Set {
  display: flex;
  flex-direction: column;
  margin: 20px;
  align-items: center;
}

.About {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-content: center;
  padding: 60px;
  margin: 60px;
}
