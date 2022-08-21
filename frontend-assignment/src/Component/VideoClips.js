import { Box} from "@mui/material";
import { DataGrid } from '@mui/x-data-grid';
import React from "react";

function VideoClips (props)
{ 
    function getTimeDuration(params)
    {
       return `${params.value.hour}:${params.value.minutes}:${params.value.sec}:${params.value.frames}`;
    }
    const columns = [
        { field: 'name', headerName: 'Name', width: 150, },
        {
          field: 'description',
          headerName: 'Description',
          width: 150,
          editable: false,
        },
        {
          field: 'endTime',
          headerName: 'TotalDuration',
          width: 210,
          editable: false,
          valueGetter : getTimeDuration,
        },

      ];

    return (
        <Box sx={{ height: 400, width: '100%' }}>
    <DataGrid
        rows={props.videoClips}
        columns={columns}
        getRowId={(row) => row.name} 
        checkboxSelection
      />   
    </Box>
    );
}

export default VideoClips;
