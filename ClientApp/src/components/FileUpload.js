﻿import React from "react";

export const FileUpload = () => {
    return (
        <form
            method="post"
            enctype="multipart/form-data"
            asp-controller="FileUpload"
            asp-action="Index"
        >
            <div class="form-group">
                <div class="col-md-10">
                    <p>Upload one or more files using this form:</p>
                    <input type="file" name="files" multiple />
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-10">
                    <input type="submit" value="Upload" />
                </div>
            </div>
        </form>
    );
};
