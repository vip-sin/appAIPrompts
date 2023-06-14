import Head from "next/head";
import Link from "next/link";
import Script from "next/script";
// what does Solid stand for OO programming?
import Layout from "../../components/layout";

export default function App() {
  // function to make an async call to jsonplaceholder to get list of todos
  async function getTodos() {
    const response = await fetch("https://jsonplaceholder.typicode.com/todos");
    const data = await response.json();
    return data;
  }
  // call getTodos in useEffect on first render
  //TODO : create an array of string with color names
  const colors = [
    "red",
    "orange",
    "yellow",
    "green",
    "blue",
    "indigo",
    "violet",
    "purple",
    "pink",
    "brown",
    "grey",
    "black",
  ];
  // create a function to return fibonacci numbers

  function fibonacci(n) {
    if (n === 0 || n === 1) {
      return 1;
    }
    return fibonacci(n - 1) + fibonacci(n - 2);
  }
  // return a function to render the fb sdk in this component using next/script and head/title
  return (
    <div className="App">
      <Head>
        <title>Next.js Boilerplate</title>
        {/* next/script  */}
      </Head>
      <div className="container">
        <h1 className="title">
          Welcome to <a href="https://nextjs.org">Next.js Boilerplate</a>
        </h1>
        <p className="description">
          Get started by editing <code>pages/index.js</code>
        </p>
        <Link href="/">Go back to the homepage</Link>
        {/* table to populate the data received from "getTodos" function  */}
        {/* <table className="table">
          <thead>
            <tr>
              <th>id</th>
              <th>title</th>
              <th>description</th>
              <th>completed</th>
            </tr>
          </thead>
          <tbody>
            {getTodos().map((todo) => (
              <tr key={todo.id}>
                <td>{todo.id}</td>
                <td>{todo.title}</td>
                <td>{todo.description}</td>
                <td>{todo.completed}</td>
              </tr>
            ))}
          </tbody>
        </table> */}
        <Script src="https://connect.facebook.net/en_US/sdk.js" />
      </div>
    </div>
  );
}
