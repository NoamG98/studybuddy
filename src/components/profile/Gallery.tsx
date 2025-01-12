import React, { useEffect, useState } from "react";
import axios from "axios";

interface Image {
  id: number;
  url: string;
}

const Gallery: React.FC = () => {
  const [images, setImages] = useState<Image[]>([]);

  useEffect(() => {
    const fetchImages = async () => {
      try {
        const response = await axios.get("http://localhost:5000/api/Images");
        setImages(response.data);
      } catch (error) {
        console.error("Error fetching images:", error);
      }
    };

    fetchImages();
  }, []);

  return (
    <div>
      <h2>Gallery</h2>
      <div className="image-grid">
        {images.map((image) => (
          <img key={image.id} src={image.url} alt="Gallery" />
        ))}
      </div>
    </div>
  );
};

export default Gallery;
