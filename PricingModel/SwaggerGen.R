# Generate Service Consumption Client Library in CSharp from swagger.json
install.packages("httr", dependencies = TRUE)
library(httr)
swaggerFileLocation <- "swagger.json"
swagger <- readChar(swaggerFileLocation, file.info(swaggerFileLocation)$size)
r <- httr::POST("http://generator.swagger.io/api/gen/clients/csharp",
                add_headers("Content-Type" = "application/json"),
                body = paste("{\"spec\":", swagger, "}"))
download.file(jsonlite::fromJSON(content(r, "text", encoding = "UTF-8"))$link, destfile = "myCsharpClient.zip", mode = "wb")