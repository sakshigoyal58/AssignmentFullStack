import logo from './logo.svg';
import './App.css';
import SearchCritera from './Component/SearchCriteria';
import VideoClips from './Component/VideoClips';
import React, {useState, useEffect} from 'react';

function App() {

  const[defintions, setDefinition] = useState([]);
  const[standards, setStandard] = useState([]);
  const[videoClips, setVideoClips] = useState([]);
  const [loading, setLoading] = useState(false);

  useEffect(() => {
    setLoading(true);
    fetch('https://localhost:7195/api/SearchCriteria/Get')
      .then((res) => res.json())
      .then((data) => {
        setDefinition(data.videoDefinitions);
        setStandard(data.videoStandards);
      })
      .catch((err) => {
        console.log(err);
      })
      .finally(() => {
        setLoading(false);
      });
  }, {});

  function getVideoClipsHandler(request)
  {
    fetch(`https://localhost:7195/api/VideoClip?VideoDefinition=${encodeURIComponent(request.VideoDefinition)}&VideoStandard=${encodeURIComponent(request.VideoStandard)}`)
    .then((res) =>res.json())
    .then((data) => {
        setVideoClips(data);
    })
    .catch((err) => {
      console.log(err);
    })

  }

  if (loading) {
    return <p>Data is loading...</p>;
  }

  return (
   <React.Fragment>
     <SearchCritera 
        videoDefinitions = {defintions} 
        videoStandards = {standards} 
        videoHandler = {getVideoClipsHandler}>
     </SearchCritera>
     <VideoClips videoClips = {videoClips}></VideoClips>
   </React.Fragment>
  );
  
}

export default App;
