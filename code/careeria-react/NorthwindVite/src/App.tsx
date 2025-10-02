import "./App.css";
import CustomerList from "./componets/CustomerList.tsx";
// import Laskuri from "./componets/Laskuri.tsx";
// import Events from "./componets/Events.tsx";

const App = () => {
  return (
    <>
      <h1 className="title-center">Vite + React</h1>
      {/* <Laskuri /> */}
      {/* <Events otsikko={"Coming events"} /> */}
      <CustomerList />
    </>
  );
};

export default App;
