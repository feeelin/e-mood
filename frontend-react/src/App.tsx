import './App.css'
import ModeSelection from "./components/modeSelection/ModeSelection.tsx";
import Header from "./components/header/header.tsx";


function App() {
  return (
    <div className={'app'}>
        <Header/>
        <div className={'contentContainer'}>
            <ModeSelection playlist_title={'Rock Classic'}/>
        </div>
    </div>
  )
}

export default App
