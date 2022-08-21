import { FormControl } from "@mui/material";
import React, { useState,useEffect } from "react";
import MenuItem from '@mui/material/MenuItem';
import { Select } from '@material-ui/core';
import InputLabel from '@mui/material/InputLabel';

function SearchCritera (props)
{   
    const[definition, updateDefintion] = useState('');
    const[value, setValue] = useState('');
    useEffect(()=>{
        CreateVideoClipRequest()
       },[definition,value])

    function HandleDefinitionChange(event)
    {
        event.preventDefault();
        updateDefintion(event.target.value);     
            
    }

    const HandleStandardChange = (event) => {setValue(event.target.value);};

    function CreateVideoClipRequest(event)
    {
        if(definition.length> 0 && value.length >0)
        {
            const request = {
                VideoDefinition: definition,
                VideoStandard: value
            }
    
            console.log(request);
            props.videoHandler(request);
        }
        
    }

    return(
        <FormControl fullWidth onSubmit={CreateVideoClipRequest}>
             <InputLabel>Video Definition</InputLabel>
            <Select id="videoDefinitionSelector"  value ={definition} label="VideoDefinition" onChange={HandleDefinitionChange}>
            {props.videoDefinitions.map(definition => { 
            return (
                <MenuItem key = {definition.value} value = {definition.value}>{definition.value}</MenuItem>
            );
            })}      
         </Select>
         <InputLabel>Video Standard</InputLabel>
         <Select id="videoStandardSelector" label="VideoStandard"
          onChange={HandleStandardChange} value = {value} >
          {props.videoStandards.map(standard => { 
                return (
                    <MenuItem key = {standard.value} value = {standard.value}>{standard.value}</MenuItem>
                );
                })}      
         </Select>
        </FormControl>
    );
}

export default SearchCritera;