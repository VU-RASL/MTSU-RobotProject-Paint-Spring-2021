import sys
import cv2
import numpy as np
import matplotlib.pyplot as plt
import json


def auto_canny(image, sigma=0.33):
    v = np.median(image)
    lower = int(max(0, (1.0 - sigma) * v))
    upper = int(min(255, (1.0 + sigma) * v))
    return cv2.Canny(image, lower, upper)


def main():
    #read an image
    image = cv2.imread(sys.argv[1])
    #gray and blur the image
    gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
    blurred = cv2.GaussianBlur(gray, (3,3), 3)
    #get dimins of the image 
    h, w, l = image.shape
    blank_image = np.zeros((h, w, 3), np.uint8)
    #fill the image with just whitespace
    blank_image.fill(255)
    
    #determine the edges and show them 
    edges = auto_canny(blurred, sigma=0.33)
    cv2.imshow('canny edges', edges)
    cv2.waitKey(0)
    
    #findContours uses the found edges to make "contours" (areas of enclosement) in the form of a 2d array 
    contours, hierarchy = cv2.findContours(edges, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)

    # loop to filter out the meaningless tiny contours
    new_contours = []
    for contour in contours:
        if len(contour) > 5:
            new_contours.append(contour)

   # display num of countours 
    segments = len(new_contours)
    print(f"new contours: {len(new_contours)}")

    # draw and show the contours using the blank image

    blank_image2 = blank_image.copy()
    #cv2.drawContours(blank_image, contours, -1, (0, 0, 0), 3)
    #cv2.imshow('contours', blank_image)

    cv2.drawContours(blank_image2, new_contours , -1, (0, 0, 0), 3)
    cv2.imshow('new contours', blank_image2)

    cv2.waitKey(0)
    cv2.destroyAllWindows()
    print("contours")
    # displaying the contour 2d array data 
   

    output = {}
    output["size"] = (h,w)
    for i, c in enumerate(new_contours):
        output[f"segment_{i+1}"] = []
        for point in c:
            output[f"segment_{i+1}"].append((point[0][0].item(),point[0][1].item()))
    
    print(output)

    with open('segments.json', 'w') as outfile:
        json.dump(output, outfile)
    


if __name__ == "__main__":
    main()


